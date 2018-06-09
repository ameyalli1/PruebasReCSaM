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
    /// Lógica de interacción para EncuestaFormulario.xaml
    /// </summary>
    public partial class EncuestaFormulario : Window
    {
        IManejadorEncuesta manejadorEncuesta;
        IManejadorPregunta manejadorPregunta;
        IManejadorRespuesta manejadorRespuesta;
        List<ClaseGeneral> clasegeneral;
        string IDPregunta = "";
        string ID;
        int contador1 = 1;
        int contador2 = 1;
        int LimiteInferior = 0;
        int numPreguntaInterfaz = 0;
        int PuntacionFinalEstadisticos = 0;
        int valor = 0;
        int ValorBase=0;
        int Next=0;
        List<ClaseGeneral> valores = new List<ClaseGeneral>();//para aleatorios de las preguntas
        List<ClaseGeneral> botonRegresar = new List<ClaseGeneral>();//lista de aleatorios para hacer la cuenta regresiva

        public EncuestaFormulario()
        {
            InitializeComponent();
            manejadorEncuesta = new ManejadorEncuesta(new RepositorioEncuesta());
            manejadorPregunta = new ManejadorPregunta(new RepositorioPregunta());
            manejadorRespuesta = new ManejadorRespuesta(new RepositorioRespuesta());
            EjemploDeLlenasDatos();
            ValorDeNumeroDePreguntaInterfaz();
        }

        private void ValorDeNumeroDePreguntaInterfaz()
        {
            txtNumeroPregunta.Text = numPreguntaInterfaz.ToString();
            numPreguntaInterfaz++;
        }


        private void ObtenerLosDatosParaRegistro() {
            ValorBase = 0;
            if (listCajaRespuestas.SelectedItem != null) {
                try
                {
                    ClaseGeneral a = listCajaRespuestas.SelectedItem as ClaseGeneral;
                    ValorBase = LimiteInferior + (manejadorPregunta.ContarPosicion(a.Datos, ID));
                    Proyecto.COMMON.Entidad.Respuesta respuesta = new Proyecto.COMMON.Entidad.Respuesta();
                    respuesta.IdEncuesta = txtIDEncuesta.Text;
                    respuesta.IdMesero = txtIDMesero.Text;
                    respuesta.IdPregunta = IDPregunta;
                    respuesta.Respuestas = ValorBase;
                    respuesta.FechaHora = DateTime.Now;
                    manejadorRespuesta.Agregar(respuesta);
                    IDPregunta = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No ha seleccionado ninguna respuesta", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }        
        }

        private void NumerosAleatorios()
        {            
            int j = 0;
            Random a = new Random();
            int ContadorPreguntas = a.Next(1, manejadorPregunta.Lista.Count);
            foreach (var item in valores)
            {
                if (item.Datos == ContadorPreguntas.ToString())
                {
                    j++;
                }
            }
            if (j==0) {
                ClaseGeneral clase = new ClaseGeneral();
                clase.Datos = ContadorPreguntas.ToString();
                valores.Add(clase);
                botonRegresar.Add(clase);
            }
        }

        private void ListaDePreguntasAleatorias() {
            for (int i = 0; i < 500; i++)
            {
                NumerosAleatorios();
                if (valores.Count==10) {
                    break;                    
                }
            }
        }

        private void EjemploDeLlenasDatos()
        {
            if (manejadorPregunta.Lista.Count <= 0)
            {
                MessageBox.Show("No cuenta con ninguna pregunta para cuestinar", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            int contador = 0;
            if (manejadorPregunta.Lista.Count < 10 && manejadorPregunta.Lista.Count >= 1)
            {
                foreach (var item in manejadorPregunta.Lista)
                {
                    contador++;
                    if (contador == contador1)
                    {
                        IDPregunta = item.Id;
                        txtPregunta.Text = item.Texto;
                        clasegeneral = item.Respuestas;
                        listCajaRespuestas.ItemsSource = clasegeneral;
                        ID = item.Id;
                        LimiteInferior = int.Parse(item.ValorMinimo);
                    }
                }
            }
            else
            {                
                    ListaDePreguntasAleatorias();//aleatorios                                            
                    int contadorValores = 0, aleatorio = 0; //Para sacar el primer valor del aleatorio
                    foreach (var item in valores)
                    {
                        contadorValores++;
                        if (contadorValores == contador2)
                        {
                            aleatorio = int.Parse(item.Datos);
                        }
                    }

                    foreach (var item in manejadorPregunta.Lista)//busqueda de la pregunta
                    {
                        contador++;
                        if (contador == aleatorio)
                        {
                            IDPregunta = item.Id;
                            txtPregunta.Text = item.Texto;
                            clasegeneral = item.Respuestas;
                            listCajaRespuestas.ItemsSource = clasegeneral;
                            ID = item.Id;
                            LimiteInferior = int.Parse(item.ValorMinimo);
                        }
                    }
            }
            ValorDeNumeroDePreguntaInterfaz();

        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (listCajaRespuestas.SelectedItem == null) {
                MessageBox.Show("No ha seleccionado la respuesta\nFavor de seleccionar una dando Doble click", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ObtenerLosDatosParaRegistro();
            Next++;
            if (Next < 10)
            {
                PuntacionFinalEstadisticos += valor;
                if (PuntacionFinalEstadisticos == 0)
                {
                    MessageBox.Show("No ha seleccionado la respuesta\nFavor de seleccionar una dando Doble click", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                contador1++;
                contador2++;
                EjemploDeLlenasDatos();
                //para llenar datos de la tabla
            }
            else {
                EncuestaComentarios encuestaComentarios= new EncuestaComentarios();
                encuestaComentarios.Show();
                this.Close();
                encuestaComentarios.txtIdEncuesta.Text = txtIDEncuesta.Text;
                encuestaComentarios.txtIdMesero.Text = txtIDMesero.Text;


            }
        }      

        private void listCajaRespuestas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            valor = 0;
            if (listCajaRespuestas.SelectedItem != null)
            {
                try
                {
                    ClaseGeneral a = listCajaRespuestas.SelectedItem as ClaseGeneral;
                    valor = LimiteInferior + (manejadorPregunta.ContarPosicion(a.Datos, ID));
                 //   MessageBox.Show("respuesta:   " + valor);

                }
                catch (Exception)
                {
                    MessageBox.Show("No ha seleccionado ninguna respuesta", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }
    }
}
