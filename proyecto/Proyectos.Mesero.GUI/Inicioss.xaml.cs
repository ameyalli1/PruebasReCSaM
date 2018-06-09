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
    /// Lógica de interacción para Inicioss.xaml
    /// </summary>
    public partial class Inicioss : Window
    {
        IManejadorMesero manejadorMeseros;
        IManejadorEmpresa manejadorEmpresa;
        public Inicioss()
        {
            InitializeComponent();
            manejadorMeseros = new ManejadorMesero(new RepositorioGenerico<Encuestador>());
            manejadorEmpresa = new ManejadorEmpresa(new RepositorioGenerico<Empresa>());
            txtPassword.Visibility = Visibility.Collapsed;

            cmbEmpresa.ItemsSource = null;
            cmbEmpresa.ItemsSource = manejadorEmpresa.Lista;

            cmbUsuario.ItemsSource = null;
            cmbUsuario.ItemsSource = manejadorMeseros.Lista;


          // InabilitarComboUsuario(false);
        }
        private void InabilitarComboUsuario(bool habilitar)
        {
          cmbUsuario.IsEnabled = habilitar;
        }

        private void CheBoxPassword_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(passPasword.Password))
            {
                txtPassword.Visibility = Visibility.Visible;
                passPasword.Visibility = Visibility.Collapsed;
                CheBoxPassword.IsChecked = false;
                return;
            }
            if (txtPassword.Visibility == Visibility.Collapsed)
            {
                passPasword.Visibility = Visibility.Collapsed;
                txtPassword.Text = passPasword.Password;
                txtPassword.Visibility = Visibility.Visible;
            }
            else
            {
                passPasword.Visibility = Visibility.Visible;
                txtPassword.Visibility = Visibility.Collapsed;
            }
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEmpresa.Text))
            {
                MessageBox.Show("No ha seleccionado la empresa a que pertenece", "ReCSaM Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(cmbUsuario.Text))
            {
                MessageBox.Show("No ha seleccionado el Usuario", "ReCSaM Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(passPasword.Password))
            {
                MessageBox.Show("No ha ingreado su contraseña", "ReCSaM Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                if ((manejadorMeseros.BuscarUsuario(cmbEmpresa.Text, cmbUsuario.Text, passPasword.Password) == 1))
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    menu.txtNombreEmpleado.Text = cmbUsuario.Text;
                    menu.txtNombreEmpresa.Text = cmbEmpresa.Text;//pasar los datos a las demas ventanas
                    this.Close();
                    MessageBox.Show("Bienvenido " + cmbUsuario.Text, "ReCSaM", MessageBoxButton.OK);
                }
                else
                {
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


        private void cmbEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        /*
            InabilitarComboUsuario(true);
            cmbUsuario.ItemsSource = null;
            cmbUsuario.ItemsSource = manejadorMeseros.BuscarEmpresaUsuario((cmbEmpresa.SelectedItem as Empresa));
            */
        }
    }
}
