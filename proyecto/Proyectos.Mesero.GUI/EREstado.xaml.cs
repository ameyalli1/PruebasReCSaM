using Proyecto.BIZ;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using Proyecto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyectos.Mesero.GUI
{
    /// <summary>
    /// Lógica de interacción para EREstado.xaml
    /// </summary>
    public partial class EREstado : Window
    {
        string respuesta = "";
        IManejadorRespuesta manejadorRespuestas;
        public EREstado()
        {
            InitializeComponent();
            manejadorRespuestas = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void SeleccionarRespuesta()
        {
            if (radCasado != null)
            {
                respuesta = radCasado.Content.ToString();
            }
            if (radDivorciado != null)
            {
                respuesta = radDivorciado.Content.ToString();
            }
            if (radSoltero != null)
            {
                respuesta = radSoltero.Content.ToString();
            }
            if (radViudo != null)
            {
                respuesta = radViudo.Content.ToString();
            }
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarRespuesta();
            if (respuesta == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "Estado civil";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuesta;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuestas.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //Ir a segunda intefaz
            ERFrecuenciaServicios eRFrecuenciaServicios = new ERFrecuenciaServicios();
            eRFrecuenciaServicios.Show();
            eRFrecuenciaServicios.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            eRFrecuenciaServicios.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }
    }
}
