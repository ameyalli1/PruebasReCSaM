using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyectos.Mesero.GUI
{
    /// <summary>
    /// Lógica de interacción para MenuAmbu.xaml
    /// </summary>
    public partial class MenuAmbu : Window
    {
        public MenuAmbu()
        {
            InitializeComponent();
        }
        private void ButtonPopup_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CerrarMenu_Click(object sender, RoutedEventArgs e)
        {
            AbrirMenu.Visibility = Visibility.Visible;
            CerrarMenu.Visibility = Visibility.Collapsed;
        }

        private void AbrirMenu_Click(object sender, RoutedEventArgs e)
        {
            AbrirMenu.Visibility = Visibility.Collapsed;
            CerrarMenu.Visibility = Visibility.Visible;
        }

        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {
          //  Menu menu = new Menu();
          //  menu.Show();
            //this.Close();
        }

        private void ButtonPopup_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
     
    }
}
