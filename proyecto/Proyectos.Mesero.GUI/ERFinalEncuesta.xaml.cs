using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para ERFinalEncuesta.xaml
    /// </summary>
    public partial class ERFinalEncuesta : Window
    {
        public ERFinalEncuesta()
        {
            InitializeComponent();
            txtNombreEmpleado.Visibility = Visibility.Collapsed;
            txtNombreEmpresa.Visibility = Visibility.Collapsed;
        }

        private void BarraDezplamiento()
        {

            BackgroundWorker iniciando = new BackgroundWorker();
            iniciando.RunWorkerCompleted += BarraCompletada;//cuando se termina la operacion
            iniciando.WorkerReportsProgress = true;
            iniciando.DoWork += BarraEnProsseso;
            iniciando.ProgressChanged += DatosDePantalla;
            iniciando.RunWorkerAsync();
        }


        private void DatosDePantalla(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void BarraEnProsseso(object sender, DoWorkEventArgs e)
        {
            var iniciando = sender as BackgroundWorker;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                iniciando.ReportProgress((i), string.Format("Cargando {0}.", i));
            }
        }

        private void BarraCompletada(object sender, RunWorkerCompletedEventArgs e)
        {
            MenuPrincipal encuesta = new MenuPrincipal();
            encuesta.Show();
            encuesta.txtNombreEmpresa.Text = txtNombreEmpresa.Text;
            encuesta.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
            this.Close();
        }

        private void btnTerminar_Click(object sender, RoutedEventArgs e)
        {
            BarraDezplamiento();
        }
    }
}
