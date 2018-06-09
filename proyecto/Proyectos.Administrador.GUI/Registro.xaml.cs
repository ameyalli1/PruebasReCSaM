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

namespace Proyectos.Administrador.GUI
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        IManejadorEmpresa manejadorEmpresa;
        public Registro()
        {
            InitializeComponent();
            manejadorEmpresa = new ManejadorEmpresa(new RepositorioGenerico<Empresa>());
            txtContrasenaLabel.Visibility = Visibility.Collapsed;
        }

        private void LimpiarCajas() {
            txtContrasena.Clear();
            txtNombreEmpresa.Clear();
        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEmpresa.Text) || string.IsNullOrEmpty(txtContrasena.Password)) {
                MessageBox.Show("No ha llenado todos los campos: Nombre o contraseña", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Empresa empresa = new Empresa();
            empresa.FechaHora = DateTime.Now;
            empresa.Nombre = txtNombreEmpresa.Text.ToUpper();
            empresa.Password = txtContrasena.Password;
            try
            {
                if (manejadorEmpresa.Agregar(empresa))
                {
                    MessageBox.Show(empresa.Nombre + " Agregada correctamente", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimpiarCajas();
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(empresa.Nombre + " No se agrego correctamente", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a Internet ", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
         
            }

        private void cheVisualizarContrasena_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Password))
            {
                MessageBox.Show("No ha introduccido la contraseña", "ReCSaM Registro", MessageBoxButton.OK, MessageBoxImage.Error);
                cheVisualizarContrasena.IsChecked = false;
                return;
            }
            if (txtContrasenaLabel.Visibility == Visibility.Collapsed)
            {
                txtContrasena.Visibility = Visibility.Collapsed;
                txtContrasenaLabel.Text = txtContrasena.Password;
                txtContrasenaLabel.Visibility = Visibility.Visible;
            }
            else
            {
                txtContrasena.Visibility = Visibility.Visible;
                txtContrasenaLabel.Visibility = Visibility.Collapsed;
            }
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
    }

