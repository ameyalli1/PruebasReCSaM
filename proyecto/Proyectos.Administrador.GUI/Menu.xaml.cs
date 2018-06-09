using Microsoft.Reporting.WinForms;
using MongoDB.Bson;
using Proyecto.BIZ;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using Proyecto.COMMON.Modelos;
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

namespace Proyectos.Administrador.GUI
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {

        enum opcion
        {
            Nuevo,
            Edita
        }
        opcion opciones;

    

        public int Editar = 0;
        public ObjectId Id;
        ObjectId ID ;
        List<ClaseGeneral> ju = new List<ClaseGeneral>();
        List<ClaseGeneral> respuestas = new List<ClaseGeneral>();
        IManejadorMesero manejadorMesero;
        IManejadorPregunta manejadorPregunta;
        IManejadorDimension manejadorDimension;
        IManejadorMesero manejadorMeseros;
        IManejadorEncuesta manejadorEncuesta;
        //        private bool MinimizeBox;

        //public bool MinimizeBox get { return maximixeBox; }  set { }; 

        public Menu()
        {
            InitializeComponent();

            manejadorMesero = new ManejadorMesero(new RepositorioGenerico<Encuestador>());
            manejadorPregunta = new ManejadorPregunta(new RepositorioGenerico<Pregunta>());
            manejadorDimension = new ManejadorDimension(new RepositorioGenerico<Dimension>());
            manejadorMeseros = new ManejadorMesero(new RepositorioGenerico<Encuestador>());
            manejadorEncuesta = new ManejadorEncuesta(new RepositorioGenerico<Encuesta>());

            CargarComboBoxDimension();
            ActualizarTablaDimension();
            CargarTablaRespuestas();
            CargarUsuariosLista();


            txtPasswordLabel.Visibility = Visibility.Collapsed;
            dtgRespuestas.Visibility= Visibility.Collapsed;
            lblNombrePregunta.Visibility = Visibility.Collapsed;



            ActualizarTabla();


        }


        private void NumerosAleatorios()
        {
            int valor = manejadorPregunta.Lista.Count();
            Random random = new Random();
            int valor2 = random.Next(1, valor);
            ClaseGeneral clase = new ClaseGeneral();
            clase.Datos = valor2.ToString();
            ju.Add(clase);
        }

        private void ListaDePreguntasAleatorias()
        {
            for (int i = 0; i < 500; i++)
            {
                NumerosAleatorios();
                if (ju.Count <= 10)
                {
                    break;
                }
            }
        }

        private void PreguntasAleatorias()
        {
            if (manejadorPregunta.Lista.Count < 10 && manejadorPregunta.Lista.Count > 0)
            {
                for (int i = 1; i <= manejadorPregunta.Lista.Count; i++)
                {
                    ClaseGeneral clase = new ClaseGeneral();
                    clase.Datos = (i).ToString();
                    ju.Add(clase);
                }
            }
            else
            {
                ListaDePreguntasAleatorias();
            }


        }
        private void ActualizarTabla()
        {
            listEncuesta.ItemsSource = null;
            listEncuesta.ItemsSource = manejadorEncuesta.Lista;
           dtgRespuestas.ItemsSource = null;
          dtgRespuestas.ItemsSource = manejadorEncuesta.Lista;
            listPreguntas.ItemsSource = null;
            listPreguntas.ItemsSource = manejadorPregunta.Lista;

            listUsuarios.ItemsSource = null;
            listUsuarios.ItemsSource = manejadorMeseros.Lista;
        }

        private void HabilitarCamposEncuesta()
        {
            txtDuenoEncuesta.Clear();
            txtNombreEncuesta.Clear();
            txtObjetivoEncuesta.Clear();
            ActualizarTabla();

        }







        private void LimpiarCajas() {
            txtApellido.Clear();
            txtCorreo.Clear();
            txtHorario.Clear();
            txtNombre.Clear();
            txtPassword.Clear();
            txtTurno.Clear();
        }

        private void CargarTablaRespuestas()
        {
            listPreguntas.ItemsSource = null;
            listPreguntas.ItemsSource = manejadorPregunta.Lista;//checar
        }


        private void CargarUsuariosLista()
        {
            listUsuarios.ItemsSource = null;
            // listUsuarios.ItemsSource = manejadorMeseros.BuscarUsuariosEmpresa(txtEmpresa.Text);
            listUsuarios.ItemsSource = manejadorMeseros.Lista;//checar
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            listUsuarios.ItemsSource = null;
            listUsuarios.ItemsSource = manejadorMeseros.BuscarUsuarioEspecifico(txtBuscador.Text.ToUpper(), txtEmpresa.Text.ToUpper());      //checar      
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Encuestador mesero = listUsuarios.SelectedItem as Encuestador;
                if (mesero != null)
                {
                    if (MessageBox.Show("Realmente esta seguro de eliminar a " + mesero.Nombres, "Eliminar usuarios", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (manejadorMeseros.Eliminar(mesero.Id))
                        {
                            MessageBox.Show("Usuario eliminado correctamente", "Eliminar usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                            CargarUsuariosLista();
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Algo salio mal, Vuelva a interntarlo de nuevo", "Eliminar usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningún Usuario para eliminar", "Eliminar usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "Eliminar usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            CargarUsuariosLista();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Encuestador mesero = listUsuarios.SelectedItem as Encuestador;
                if (mesero != null)
                {
                    if (MessageBox.Show("Realmente esta seguro de editar al usario " + mesero.Empresa, "Editar Usuarios", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {                        
                        Id = mesero.Id;
                        txtApellido.Text = mesero.Apellidos;
                        txtCorreo.Text = mesero.Correo;
                        txtEmpresa.Text = mesero.Empresa;
                        txtHorario.Text = mesero.Horario;
                        txtNombre.Text = mesero.Nombres;
                        txtPassword.Password = mesero.Password;
                        txtTurno.Text = mesero.Turno;
                        Editar = 1;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "Editar Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTurno.Text)) {
                MessageBox.Show("Falta agregar todos los datos", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                if (Editar == 1)
                {
                    foreach (var item in manejadorMesero.Lista)
                    {
                        if (item.Id == Id)
                        {
                            item.Apellidos = txtApellido.Text.ToUpper();
                            item.Correo = txtCorreo.Text.ToUpper();
                            item.Empresa = txtEmpresa.Text.ToUpper();
                            item.FechaHora = DateTime.Now;
                            item.Horario = txtHorario.Text.ToUpper();
                            item.Nombres = txtNombre.Text.ToUpper();
                            item.Password = txtPassword.Password;
                            item.Turno = txtTurno.Text.ToUpper();
                            if (manejadorMesero.Modificar(item))
                            {
                                MessageBox.Show(item.Nombres + " Editado Correctamente", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Information);
                                LimpiarCajas();
                                Editar = 0;
                                ActualizarTabla();
                            }
                            else
                            {
                                MessageBox.Show(item.Nombres + " No se edito correctamente", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            }
                        }
                    }
                }
                else {

                    Encuestador mesero = new Encuestador();
                    mesero.Apellidos = txtApellido.Text.ToUpper();
                    mesero.Correo = txtCorreo.Text.ToUpper();
                    mesero.Empresa = txtEmpresa.Text.ToUpper();
                    mesero.FechaHora = DateTime.Now;
                    mesero.Horario = txtHorario.Text.ToUpper();
                    mesero.Nombres = txtNombre.Text.ToUpper();
                    mesero.Password = txtPassword.Password;
                    mesero.Turno = txtTurno.Text.ToUpper();
                    if (manejadorMesero.Agregar(mesero))
                    {
                        MessageBox.Show(mesero.Nombres + " Agregado Correctamente", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimpiarCajas();
                        ActualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show(mesero.Nombres + " No se agrego correctamente", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Realmente esta seguro de cancelar la operación", "ReCSaM Registro", MessageBoxButton.YesNo, MessageBoxImage.Question)) == MessageBoxResult.Yes) {
                LimpiarCajas();
                ActualizarTabla();
            }
        }       

        private void cheVisualizarContrasena_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("No ha introduccido la contraseña", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
                cheVisualizarContrasena.IsChecked = false;
                return;
            }
            if (txtPasswordLabel.Visibility == Visibility.Collapsed)
            {
                txtPassword.Visibility = Visibility.Collapsed;
                txtPasswordLabel.Text = txtPassword.Password;
                txtPasswordLabel.Visibility = Visibility.Visible;
            }
            else
            {
                txtPassword.Visibility = Visibility.Visible;
                txtPasswordLabel.Visibility = Visibility.Collapsed;
            }
        }
        //para opcion de preguntas
        private void LimpiarCamposPreguntas() {
            txtPregunta.Clear();
            txtRespuestaPreguntas.Clear();
            txtValorMaximoPreguntas.Clear();
            txtValorMinimoPreguntas.Clear();
            dtgRespuestas.ItemsSource = null;
            cmbDimensionPreguntas.ItemsSource = null;
            CargarComboBoxDimension();
        }

        private void CargarComboBoxDimension() {
            cmbDimensionPreguntas.ItemsSource = null;
          //  cmbDimensionPreguntas.ItemsSource = manejadorDimension.Lista;//solo pedir 
            cmbDimensionPreguntas.ItemsSource = manejadorDimension.BuscarDimension(txtEmpresa.Text);
        }

        private void dtgRespuestas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgRespuestas.SelectedItem != null)
            {
                try
                {
                    ClaseGeneral a = dtgRespuestas.SelectedItem as ClaseGeneral;
                    txtRespuestaPreguntas.Text = a.Datos;
                    respuestas.Remove(a);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo ha salido mal, Vuelva a intentarlo", "ReCSaM Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna respuesta para editar\nSeleccione una", "ReCSaM Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarPreguntas_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Realmente esta seguro de cancelar la operación", "ReCSaM Preguntas", MessageBoxButton.YesNo, MessageBoxImage.Question)) == MessageBoxResult.Yes)
            {
                LimpiarCamposPreguntas();
            }
        }

        private void btnGuardarPreguntas_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtPregunta.Text) || string.IsNullOrEmpty(txtValorMaximoPreguntas.Text) || string.IsNullOrEmpty(txtValorMinimoPreguntas.Text))
            {
                MessageBox.Show("Favor de llenar los datos que faltan", "ReCSaM Registro de preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (manejadorPregunta.VerificarSiEsNumero(txtValorMaximoPreguntas.Text) == true || manejadorPregunta.VerificarSiEsNumero(txtValorMinimoPreguntas.Text) == true)
            {
                MessageBox.Show("Los campos valor minimo y valor maximo deben ser numericos", "ReCSaM Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Editar == 1)
            {
                foreach (var item in manejadorPregunta.Lista)
                {
                    if (item.Id == Id)
                    {
                        item.FechaHora = DateTime.Now;
                        item.Texto = txtPregunta.Text.ToUpper();
                        item.ValorMaximo = txtValorMaximoPreguntas.Text;
                        item.ValorMinimo = txtValorMinimoPreguntas.Text;
                        item.Dimension = cmbDimensionPreguntas.Text;
                        if (manejadorPregunta.Modificar(item))
                        {
                            MessageBox.Show("Pregunta modificada Correctamente", "ReCSaM Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Information);
                            LimpiarCamposPreguntas();
                            Editar = 0;
                            ActualizarTabla();
                            // dtgRespuestas.Visibility = Visibility.Collapsed;
                            //lblNombrePregunta.Visibility = Visibility.Collapsed;
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar la pregunta ", "ReCSaM Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            else
            {
                if (respuestas.Count == 0)
                {
                    MessageBox.Show("Favor de agregar una respuesta a la pregunta", "ReCSaM Registro de preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Pregunta preguntas = new Pregunta()
                {
                    Texto = txtPregunta.Text.ToUpper(),
                    ValorMaximo = txtValorMaximoPreguntas.Text,
                    ValorMinimo = txtValorMinimoPreguntas.Text,
                    Respuestas = respuestas,
                    FechaHora = DateTime.Now,
                    Dimension = cmbDimensionPreguntas.Text,

                };
               

                if (manejadorPregunta.Agregar(preguntas))
                {
                    MessageBox.Show("Pregunta agregada correctamente", "ReCSaM Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Information);
                  
                    LimpiarCamposPreguntas();
                    ActualizarTabla();

                }
                else
                {
                    MessageBox.Show("Error al agregar la pregunta", "Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnAgregarRespuestas_Click(object sender, RoutedEventArgs e)
        {
            dtgRespuestas.Visibility = Visibility.Visible;
            lblNombrePregunta.Visibility = Visibility.Visible;
            if (string.IsNullOrEmpty(txtRespuestaPreguntas.Text))
            {
                MessageBox.Show("No ha llenado la casilla de Respuesta", "Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ClaseGeneral a = new ClaseGeneral();
            a.Datos = txtRespuestaPreguntas.Text.ToUpper();
            respuestas.Add(a);
            dtgRespuestas.ItemsSource = null;
            dtgRespuestas.ItemsSource = respuestas;
            txtRespuestaPreguntas.Clear();
          
        }


       

        private void ActualizarTablaDimension(){
            dtgDimension.ItemsSource = null;
            dtgDimension.ItemsSource = manejadorDimension.Lista;
            txtDescripcionDimension.Clear();
            txtNombreDimension.Clear();           
        }

        private void btnRegistrarDimension_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionDimension.Text)|| string.IsNullOrEmpty(txtNombreDimension.Text)) {
                MessageBox.Show("No ha llenado todos los datos completamente", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                if (Editar == 1)
                {
                    dtgRespuestas.Visibility = Visibility.Visible;
                    lblNombrePregunta.Visibility = Visibility.Visible;
                    Dimension dimension = dtgDimension.SelectedItem as Dimension;
                    dimension.Nombre = txtNombreDimension.Text.ToUpper();
                    dimension.Descripcion = txtDescripcionDimension.Text.ToUpper();
                    dimension.FechaHora = DateTime.Now;
                    dimension.NombreEmpresa = txtEmpresa.Text.ToUpper();
                    if (manejadorDimension.Modificar(dimension))
                    {
                        MessageBox.Show(dimension.Nombre + " Editada correctamente", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Information);
                        ActualizarTablaDimension();
                        CargarComboBoxDimension();
                        Editar = 0;
                    }
                    else
                    {
                        MessageBox.Show("No se edito " + dimension.Nombre + " correctamente", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else {
                    Dimension dimension = new Dimension();
                    dimension.Nombre = txtNombreDimension.Text.ToUpper();
                    dimension.Descripcion = txtDescripcionDimension.Text.ToUpper();
                    dimension.FechaHora = DateTime.Now;
                    dimension.NombreEmpresa = txtEmpresa.Text.ToUpper();
                    if (manejadorDimension.Agregar(dimension))
                    {
                        MessageBox.Show(dimension.Nombre + " Agregada correctamente", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Information);
                        dtgRespuestas.Visibility = Visibility.Collapsed;
                        lblNombrePregunta.Visibility = Visibility.Collapsed;
                        ActualizarTablaDimension();
                        CargarComboBoxDimension();
                    }
                    else {
                        MessageBox.Show("No se agrego "+dimension.Nombre+ " correctamente", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        
        private void btnEliminarDimension_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dimension dimension = dtgDimension.SelectedItem as Dimension;
                if (dimension != null)
                {
                    if (MessageBox.Show("Realmente esta seguro de eliminar la dimensión "+ dimension.Nombre, "ReCSaM Eliminar dimensión", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (manejadorDimension.Eliminar(dimension.Id))
                        {
                            MessageBox.Show("Dimensión eliminada correctamente", "ReCSaM Eliminar dimensión", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTablaDimension();
                            CargarComboBoxDimension();
                        }
                        else
                        {
                            MessageBox.Show("Algo salio mal, Vuelva a interntarlo de nuevo", "ReCSaM Eliminar dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ninguna dimensión para eliminar", "ReCSaM Eliminar dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "ReCSaM Eliminar dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void btnCancelarDimension_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Realmente esta seguro de cancelar la operación", "ReCSaM Registro de Dimensión", MessageBoxButton.YesNo, MessageBoxImage.Question)) == MessageBoxResult.Yes)
            {
                ActualizarTablaDimension();
            }
        }
      

        private void btnReporteUsuarios_Click(object sender, RoutedEventArgs e)
        {            
            List<ReportDataSource> datos = new List<ReportDataSource>();
            ReportDataSource reporte = new ReportDataSource();
            List<ModeloUsuarios> datosTorneo = new List<ModeloUsuarios>();
            foreach (var item in manejadorMesero.Lista)
            {               
                datosTorneo.Add(new ModeloUsuarios(item));
            }
            reporte.Value = datosTorneo;
            reporte.Name = "DataSet1";
            datos.Add(reporte);
            Reportador ventana = new Reportador("Proyectos.Administrador.GUI.Reporte.ReporteUsuarioSinParametros.rdlc",datos);//("Torneo.GUI.Reporte.ReporteSinParametros.rdlc", datos);
            ventana.ShowDialog();
        }

        private void btnReportePreguntas_Click(object sender, RoutedEventArgs e)
        {
            List<ReportDataSource> datos = new List<ReportDataSource>();
            ReportDataSource reporte = new ReportDataSource();
            List<ModelorPreguntas> datosPreguntas = new List<ModelorPreguntas>();
            foreach (var item in manejadorPregunta.Lista)
            {
                datosPreguntas.Add(new ModelorPreguntas(item));
            }
            reporte.Value = datosPreguntas;
            reporte.Name = "DataSet1";
            datos.Add(reporte);
            Reportador ventana = new Reportador("Proyectos.Administrador.GUI.Reporte.ReportePreguntas.rdlc", datos);//("Torneo.GUI.Reporte.ReporteSinParametros.rdlc", datos);
            ventana.ShowDialog();
        }

        private void btnEditarPregunta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pregunta pregunta = listPreguntas.SelectedItem as Pregunta;
                if (pregunta != null)
                {
                    if (MessageBox.Show("Realmente esta seguro de editar la pregunta ", "Editar pregunta", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {

                        respuestas = pregunta.Respuestas;
                        dtgRespuestas.Visibility = Visibility.Visible;
                        lblNombrePregunta.Visibility = Visibility.Visible;
                        Id = pregunta.Id;
                        txtPregunta.Text = pregunta.Texto;
                        cmbDimensionPreguntas.Text = pregunta.Dimension;
                        dtgRespuestas.ItemsSource = pregunta.Respuestas;
                        txtValorMaximoPreguntas.Text = pregunta.ValorMaximo;
                        txtValorMinimoPreguntas.Text = pregunta.ValorMinimo;
                        Editar = 1;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "Editar Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void btnEliminarPRegunta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pregunta pregunta = listPreguntas.SelectedItem as Pregunta;
                if (pregunta != null)
                {
                    if (MessageBox.Show("Realmente esta seguro de eliminar a la pregunta", "Eliminar preguntas", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (manejadorPregunta.Eliminar(pregunta.Id))
                        {
                            MessageBox.Show("Usuario eliminado correctamente", "Eliminar preguntas", MessageBoxButton.OK, MessageBoxImage.Information);
                            CargarTablaRespuestas();
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Algo salio mal, Vuelva a interntarlo de nuevo", "Eliminar preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ninguna pregunta para eliminar", "Eliminar preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "Eliminar preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void btnEditarDimension_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgDimension.SelectedItem != null)
                {
                    Dimension dimension = dtgDimension.SelectedItem as Dimension;
                    txtDescripcionDimension.Text = dimension.Descripcion;
                    txtNombreDimension.Text = dimension.Nombre;
                    Editar = 1;
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun elemento de la tabla Dimension", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet", "ReCSaM Registro de Dimensión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }







        private void btnGuardarEncuesta_Click(object sender, RoutedEventArgs e)
        {
            //ListaDePreguntasAleatorias();
            PreguntasAleatorias();
            if (manejadorPregunta.Lista.Count < 1)
            {
                MessageBox.Show("No cuenta con preguntas, Favor de ingresar antes que agregar una nueva encuesta", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (opciones == opcion.Edita)
            {
                foreach (var item in manejadorEncuesta.Lista)
                {
                    if (item.Id == ID)
                    {
                        item.FechaHora = DateTime.Now;
                        item.Nombre = txtNombreEncuesta.Text;
                        item.Objetivo = txtObjetivoEncuesta.Text;
                        item.Duenio = txtDuenoEncuesta.Text;
                        if (manejadorEncuesta.Modificar(item))
                        {
                            MessageBox.Show("Encuesta modificada Correctamente", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                            HabilitarCamposEncuesta();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar la Encuesta ", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            else
            {
                Encuesta encuesta = new Encuesta();
                encuesta.Duenio = txtDuenoEncuesta.Text;
                encuesta.FechaHora = DateTime.Now;
                encuesta.Nombre = txtNombreEncuesta.Text;
                encuesta.Objetivo = txtObjetivoEncuesta.Text;
                encuesta.MostrarPreguntasAleatoriamente = ju;
                if (manejadorEncuesta.Agregar(encuesta))
                {
                    MessageBox.Show("Datos agregados Correctamente", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarCamposEncuesta();
                }
                else
                {
                    MessageBox.Show("Los datos no se  agregaron correctamente", "Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    ActualizarTabla();
                }
            }
        }

        private void btnEditarEncuesta_Click(object sender, RoutedEventArgs e)
        {
            if (listEncuesta.SelectedItem != null)
            {
                try
                {
                    Encuesta encuesta = listEncuesta.SelectedItem as Encuesta;
                    ID = encuesta.Id;
                    txtDuenoEncuesta.Text = encuesta.Duenio;
                    txtNombreEncuesta.Text = encuesta.Nombre;
                    txtObjetivoEncuesta.Text = encuesta.Objetivo;
                    //   dtgrespuestas.ItemsSource = encuesta.MostrarPreguntasAleatoriamente;
                    opciones = opcion.Edita;
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salio mal no se puede editar la encuesta", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un dato de la tabla Encuesta", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarEncuesta_Click(object sender, RoutedEventArgs e)
        {
            Encuesta encuesta = listEncuesta.SelectedItem as Encuesta;
            if (encuesta != null)
            {
                try
                {
                    if ((MessageBox.Show("Esta seguro de eliminar la encuesta ", "Registro de Encuesta", MessageBoxButton.YesNo, MessageBoxImage.Question)) == (MessageBoxResult.Yes))
                    {
                        if (manejadorEncuesta.Eliminar(encuesta.Id))
                        {
                            MessageBox.Show("Encuesta eliminada con Éxito", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                            HabilitarCamposEncuesta();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar Encuesta", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de Seleccionar un dato de la tabla", "Registro de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarEncuesta_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("¿Esta realmente seguro de cancelar la operación?", "Registro de Preguntas", MessageBoxButton.YesNo, MessageBoxImage.Question)) == MessageBoxResult.Yes)
            {
                ActualizarTabla();
                HabilitarCamposEncuesta();
            }
        }

        private void dtgRespuestas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dtgRespuestas_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (dtgRespuestas.SelectedItem != null)
            {
                try
                {
                    ClaseGeneral a = dtgRespuestas.SelectedItem as ClaseGeneral;
                    txtRespuestaPreguntas.Text = a.Datos;
                    respuestas.Remove(a);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo ha salido mal, Vuelva a intentarlo", "Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna respuesta para editar\nSeleccione una", "Registro de Preguntas", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
