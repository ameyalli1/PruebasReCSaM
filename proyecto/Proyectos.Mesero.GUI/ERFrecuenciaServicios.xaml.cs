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
    /// Lógica de interacción para ERFrecuenciaServicios.xaml
    /// </summary>
    public partial class ERFrecuenciaServicios : Window
    {
        string respuesta = "";
        IManejadorRespuesta manejadorRespuesta;
        public ERFrecuenciaServicios()
        {
            InitializeComponent();
            manejadorRespuesta = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void SeleccionarRespuesta()
        {
            if (radPrimera.IsChecked != false)
            {
                respuesta = radPrimera.Content.ToString();
            }
            if (radSegunda.IsChecked != false)
            {
                respuesta = radSegunda.Content.ToString();
            }
            if (radTercera.IsChecked != false)
            {
                respuesta = radTercera.Content.ToString();
            }
            if (radCuarta.IsChecked != false)
            {
                respuesta = radCuarta.Content.ToString();
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
                respuestas.IdPregunta = "Frecuencia en la que ha utiliza nuestros servicios";
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
            ERFrecuencia eRFrecuencia = new ERFrecuencia();
            eRFrecuencia.Show();
            eRFrecuencia.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            eRFrecuencia.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }
    }
}