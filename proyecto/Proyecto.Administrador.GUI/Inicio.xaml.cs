﻿using System;
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

namespace Proyecto.Administrador.WPF.GUI
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
          //  BarraDeDexplazamiento();
        }

        private void BarraDeDexplazamiento() {
            if (BarraProgreso.Value < 100)
            {
                BarraProgreso.Value = BarraProgreso.Value + 10;
                txtLeyenda.Text = "Cargando el Sistema al " + BarraProgreso.Value + "%";

            }
            else {
                MessageBox.Show("Sii");
            }
        }
    }
}
