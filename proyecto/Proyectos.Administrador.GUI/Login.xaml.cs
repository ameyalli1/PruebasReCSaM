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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        IManejadorEmpresa manejadorEmpresa;
        public Login()
        {
            InitializeComponent();
            manejadorEmpresa = new ManejadorEmpresa(new RepositorioGenerico<Empresa>());
            cmbEmpresa.ItemsSource = null;
            cmbEmpresa.ItemsSource = manejadorEmpresa.Lista;
            txtContrasenaLabel.Visibility = Visibility.Collapsed;
        }
        

        private void BtnRegistro_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro();            
            registro.Show();
            this.Close();
        }      

        private void cheVisualizarContrasena_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Password))
            {
                MessageBox.Show("No ha introduccido la contraseña", "ReCSaM Login", MessageBoxButton.OK, MessageBoxImage.Error);
                cheVisualizarContrasena.IsChecked = false;
                return;
            }
            if (txtContrasenaLabel.Visibility == Visibility.Collapsed)
            {
                txtContrasena.Visibility = Visibility.Collapsed;
                txtContrasenaLabel.Text = txtContrasena.Password;
                txtContrasenaLabel.Visibility = Visibility.Visible;
            }
            else {
                txtContrasena.Visibility = Visibility.Visible;
                txtContrasenaLabel.Visibility = Visibility.Collapsed;
            }           
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Password) || string.IsNullOrEmpty(cmbEmpresa.Text)) {
                MessageBox.Show("No ha ingresado todos los datos", "ReCSaM Login", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                if ((manejadorEmpresa.BuscarUsuario(txtContrasena.Password, cmbEmpresa.Text)) == 1)
                {
                    MainWindow menu = new MainWindow();
                    menu.Show();
                    this.Close();

                    //menu.txtEmpresa.Text = cmbEmpresa.Text;//para mandar el nombre de la empresa
                }
                else {
                    MessageBox.Show("Contraseña incorrecta!!", "ReCSaM Login", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No cuenta con conexión a internet", "ReCSaM Login", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

    }
}
