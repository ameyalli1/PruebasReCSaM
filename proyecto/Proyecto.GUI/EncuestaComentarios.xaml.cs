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

namespace Proyecto.GUI
{
    /// <summary>
    /// Lógica de interacción para EncuestaComentarios.xaml
    /// </summary>
    public partial class EncuestaComentarios : Window
    {
        IManejadorRespuesta manejadorRespuesta;
        public EncuestaComentarios()
        {
            InitializeComponent();
            manejadorRespuesta = new ManejadorRespuesta(new RepositorioRespuesta());
        }

        private void ObtenerLosDatosParaRegistro()
        {
            try
                {                    
                    Proyecto.COMMON.Entidad.Respuesta respuesta = new Proyecto.COMMON.Entidad.Respuesta();
                    //respuesta.IdEncuesta = txtIdEncuesta.Text;
                    //respuesta. = txtIdMesero.Text;
                    respuesta.Respuestas = 5;
                    respuesta.FechaHora = DateTime.Now;
                     manejadorRespuesta.Agregar(respuesta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vuelva a intentarlo", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }           
        }

        private void btnFinalizarEncuesta_Click(object sender, RoutedEventArgs e)
        {
            ObtenerLosDatosParaRegistro();
            MenuFinalDeEncuesta menuFinalDeEncuesta = new MenuFinalDeEncuesta();
            menuFinalDeEncuesta.Show();
            this.Close();
        }
    }
}
