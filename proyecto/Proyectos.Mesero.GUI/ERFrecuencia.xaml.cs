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
    /// Lógica de interacción para ERFrecuencia.xaml
    /// </summary>
    public partial class ERFrecuencia : Window
    {
        string respuesta = "";
        IManejadorRespuesta manejadorRespuesta;
        public ERFrecuencia()
        {
            InitializeComponent();
            manejadorRespuesta = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void SeleccionarRespuesta()
        {
            if (radAnual.IsChecked != false)
            {
                respuesta = radAnual.Content.ToString();
            }
            if (radMensual.IsChecked != false)
            {
                respuesta = radMensual.Content.ToString();
            }
            if (radQuincenal.IsChecked != false)
            {
                respuesta = radQuincenal.Content.ToString();
            }
            if (radSemanal.IsChecked != false)
            {
                respuesta = radSemanal.Content.ToString();
            }
            if (radSemestral.IsChecked != false)
            {
                respuesta = radSemestral.Content.ToString();
            }
            if (radTrimestral.IsChecked != false)
            {
                respuesta = radTrimestral.Content.ToString();
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
                respuestas.IdPregunta = "¿Con qué frecuencia utiliza nuestros servicios?";
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
            ERCalidad eRCalidad = new ERCalidad();
            eRCalidad.Show();
            eRCalidad.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            eRCalidad.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }
    }
}
