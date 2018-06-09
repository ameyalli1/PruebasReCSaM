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
    /// Lógica de interacción para Recomendacion.xaml
    /// </summary>
    public partial class Recomendacion : Window
    {
        string respuesta = "";
        IManejadorRespuesta manejadorRespuesta;
        public Recomendacion()
        {
            InitializeComponent();
            manejadorRespuesta = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void SeleccionarRespuesta()
        {
            if (radNo.IsChecked != false)
            {
                respuesta = radNo.Content.ToString();
            }
            if (radSi.IsChecked != false)
            {
                respuesta = radSi.Content.ToString();
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
                respuestas.IdPregunta = "¿Recomendaría nuestra empresa?";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuesta;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }//par ir a la siguiente interfaz
            ERFinalEncuesta eRFinalEncuesta = new ERFinalEncuesta();
            eRFinalEncuesta.Show();
            eRFinalEncuesta.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            eRFinalEncuesta.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }
    }
}
