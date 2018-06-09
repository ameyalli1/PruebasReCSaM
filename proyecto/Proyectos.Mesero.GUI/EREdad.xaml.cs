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
    /// Lógica de interacción para EREdad.xaml
    /// </summary>
    public partial class EREdad : Window
    {
        string respuesta = "";
        IManejadorRespuesta manejadorRespuestas;
        public EREdad()
        {
            InitializeComponent();
            manejadorRespuestas = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void SeleccionarRespuesta()
        {
            if (rad18.IsChecked != false)
            {
                respuesta = rad18.Content.ToString();
            }
            if (rad25.IsChecked != false)
            {
                respuesta = rad25.Content.ToString();
            }
            if (rad35.IsChecked != false)
            {
                respuesta = rad35.Content.ToString();
            }
            if (rad45.IsChecked != false)
            {
                respuesta = rad45.Content.ToString();
            }
            if (rad55.IsChecked != false)
            {
                respuesta = rad55.Content.ToString();
            }
            if (rad65.IsChecked != false)
            {
                respuesta = rad65.Content.ToString();
            }
            if (rad75.IsChecked != false)
            {
                respuesta = rad75.Content.ToString();
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
                respuestas.IdPregunta = "Indique su rengo de edad";
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
            //Cambio de interfaz
            EREstado eREstadoCivil = new EREstado();
            eREstadoCivil.Show();
            eREstadoCivil.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            eREstadoCivil.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }
    }
}
