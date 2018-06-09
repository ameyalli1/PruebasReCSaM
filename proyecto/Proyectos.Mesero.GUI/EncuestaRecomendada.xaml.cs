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
    /// Lógica de interacción para EncuestaRecomendada.xaml
    /// </summary>
    public partial class EncuestaRecomendada : Window
    {
        public EncuestaRecomendada()
        {
            InitializeComponent();
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
            txtEvaluarDesicion.Visibility = Visibility.Collapsed;
        }

        private void btnVerPoliticas_Click(object sender, RoutedEventArgs e)
        {
            VerPoliticas verPoliticas = new VerPoliticas();
            verPoliticas.Show();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (txtEvaluarDesicion.Text == "1")
            {
                EREdad eREdad = new EREdad();
                eREdad.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
                eREdad.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
                eREdad.Show();
                this.Close();
            }
            else
            {

            }

        }
    }
}