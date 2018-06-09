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
    /// Lógica de interacción para ERCalidad.xaml
    /// </summary>
    public partial class ERCalidad : Window
    {
        string respuestaUno = "";
        string respuestaDos = "";
        string respuestaTres = "";
        string respuestaCuatro = "";
        string respuestaCinco = "";
        string respuestaSeis = "";
        string respuestaSiete = "";
        IManejadorRespuesta manejadorRespuesta;
        public ERCalidad()
        {
            InitializeComponent();
            manejadorRespuesta = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void CalificacionEmpleado()
        {//primera pregunta

            if (radBuenoUno.IsChecked != false)
            {
                respuestaUno = "4";
            }
            if (radMaloUno.IsChecked != false)
            {
                respuestaUno = "2";
            }
            if (radMuyBuenoUno.IsChecked != false)
            {
                respuestaUno = "5";
            }
            if (radMuyMaloUno.IsChecked != false)
            {
                respuestaUno = "1";
            }
            if (radRegularUno.IsChecked != false)
            {
                respuestaUno = "3";
            }
            if (respuestaUno == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta 1°\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "¿Como calificaría la cortesia y trato de los empleados?";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaUno;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 1°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RapidezServicio()//segunda pregunta
        {
            if (radBuenoDos.IsChecked != false)
            {
                respuestaDos = "4";
            }
            if (radMaloDos.IsChecked != false)
            {
                respuestaDos = "2";
            }
            if (radMuyBuenoDos.IsChecked != false)
            {
                respuestaDos = "5";
            }
            if (radMuyMaloDos.IsChecked != false)
            {
                respuestaDos = "1";
            }
            if (radRegularDos.IsChecked != false)
            {
                respuestaDos = "3";
            }
            if (respuestaDos == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta de la pregunta 2°\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "¿La rapidez con la que le fue otorgado el servicio? ";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaDos;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 2°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimpiezaEmpresa()//tercera pregunta
        {
            if (radBuenoTres.IsChecked != false)
            {
                respuestaTres = "4";
            }
            if (radMaloTres.IsChecked != false)
            {
                respuestaTres = "2";
            }
            if (radMuyBuenoTres.IsChecked != false)
            {
                respuestaTres = "5";
            }
            if (radMuyMaloTres.IsChecked != false)
            {
                respuestaTres = "1";
            }
            if (radRegularTres.IsChecked != false)
            {
                respuestaTres = "3";
            }
            if (respuestaTres == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta 3°\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "¿Cómo calificaría la limpieza de la empresa?";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaTres;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 3°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CalidadServicio()//Cuarta pregunta
        {
            if (radBuenoCuatro.IsChecked != false)
            {
                respuestaCuatro = "4";
            }
            if (radMaloCuatro.IsChecked != false)
            {
                respuestaCuatro = "2";
            }
            if (radMuyBuenoCuatro.IsChecked != false)
            {
                respuestaCuatro = "5";
            }
            if (radMuyMaloCuatro.IsChecked != false)
            {
                respuestaCuatro = "1";
            }
            if (radRegularCuatro.IsChecked != false)
            {
                respuestaCuatro = "3";
            }
            if (respuestaCuatro == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta 4°\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "La calidad del servicio recibido ha sido";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaCuatro;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 4°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PrecioCalidad()//Quinta pregunta
        {
            if (radBuenoCinco.IsChecked != false)
            {
                respuestaCinco = "4";
            }
            if (radMaloCinco.IsChecked != false)
            {
                respuestaCinco = "2";
            }
            if (radMuyBuenoCinco.IsChecked != false)
            {
                respuestaCinco = "5";
            }
            if (radMuyMaloCinco.IsChecked != false)
            {
                respuestaCinco = "1";
            }
            if (radRegularCinco.IsChecked != false)
            {
                respuestaCinco = "3";
            }
            if (respuestaCinco == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta 5°\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "La relación precio/calidad del servicio es: ";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaCinco;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 5°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InstalacionFisica()//Seis pregunta
        {
            if (radBuenoSeis.IsChecked != false)
            {
                respuestaSeis = "4";
            }
            if (radMaloSeis.IsChecked != false)
            {
                respuestaSeis = "2";
            }
            if (radMuyBuenoSeis.IsChecked != false)
            {
                respuestaSeis = "5";
            }
            if (radMuyMaloSeis.IsChecked != false)
            {
                respuestaSeis = "1";
            }
            if (radRegularSeis.IsChecked != false)
            {
                respuestaSeis = "3";
            }
            if (respuestaSeis == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "Las instalaciones físicas son visualmente atractivas.";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaSeis;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 6°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void HorarioEmpresa()//Siete pregunta
        {
            if (radBuenoSiete.IsChecked != false)
            {
                respuestaSiete = "4";
            }
            if (radMaloSiete.IsChecked != false)
            {
                respuestaSiete = "2";
            }
            if (radMuyBuenoSiete.IsChecked != false)
            {
                respuestaSiete = "5";
            }
            if (radMuyMaloSiete.IsChecked != false)
            {
                respuestaSiete = "1";
            }
            if (radRegularSiete.IsChecked != false)
            {
                respuestaSiete = "3";
            }
            if (respuestaSiete == "")
            {
                MessageBox.Show("No ha seleccionado una respuesta 7°\nFavor de seleccionar una", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Respuesta respuestas = new Respuesta();
                respuestas.FechaHora = DateTime.Now;
                respuestas.IdEncuesta = "Recomendada";
                respuestas.IdPregunta = "La empresa tiene horarios convenientes para usted.";
                respuestas.Latitud = 0;
                respuestas.Longitud = 0;
                respuestas.Respuestas = respuestaSiete;
                respuestas.Empresas = txtNombreEmpresa.Text;
                respuestas.Encuestador = txtNombreEmpleado.Text;
                if (manejadorRespuesta.Agregar(respuestas) == false)
                {
                    MessageBox.Show("No se agrego correctamente la pregunta 7°", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "Error de Internet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSiguiente_Click_1(object sender, RoutedEventArgs e)
        {
            CalificacionEmpleado();
            RapidezServicio();
            LimpiezaEmpresa();
            CalidadServicio();
            PrecioCalidad();
            InstalacionFisica();
            HorarioEmpresa();
            Recomendacion recomendacion = new Recomendacion();
            recomendacion.Show();
            recomendacion.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            recomendacion.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }
    }
}
