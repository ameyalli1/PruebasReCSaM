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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            txtfecha.Text = DateTime.Now.ToLongDateString();
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void Recomendada_Click(object sender, RoutedEventArgs e)
        {
            EncuestaRecomendada encuestaRecomendada = new EncuestaRecomendada();
            encuestaRecomendada.Show();
            encuestaRecomendada.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            encuestaRecomendada.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            encuestaRecomendada.txtEvaluarDesicion.Text = "1";
            this.Close();
        }

    }
}
