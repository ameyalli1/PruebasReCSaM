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

namespace Proyectos.Administrador.GUI
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
            BarraDezplamiento();
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
            progBarraDeDesplazamiento.Value = e.ProgressPercentage;
            txtBarra.Text = (string)e.UserState;
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
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
