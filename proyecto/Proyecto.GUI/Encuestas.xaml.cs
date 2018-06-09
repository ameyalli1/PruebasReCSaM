﻿using Proyecto.BIZ;
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

namespace Proyecto.GUI
{
    /// <summary>
    /// Lógica de interacción para Encuesta.xaml
    /// </summary>
    public partial class Encuestas : Window
    {
        IManejadorEmpresa manejadorEmpresa;
        IManejadorMesero manejadorMesero;
        IManejadorEncuesta manejadorEncuesta;
        public Encuestas()
        {
            InitializeComponent();
            manejadorEmpresa = new ManejadorEmpresa(new RepositorioEmpresa());
            manejadorMesero = new ManejadorMesero(new RepositorioMesero());
            manejadorEncuesta = new ManejadorEncuesta(new RepositorioEncuesta());
            CargarTabla();
        }

        private void CargarTabla()
        {
            CmbEmpresaEncuesta.ItemsSource = null;
            CmbEmpresaEncuesta.ItemsSource = manejadorEmpresa.Lista;
            CmbNombreEncuesta.ItemsSource = null;
            CmbNombreEncuesta.ItemsSource = manejadorMesero.Lista;
        }
               

        private void EntrarEncuesta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CmbNombreEncuesta.Text) || string.IsNullOrEmpty(CmbEmpresaEncuesta.Text) || string.IsNullOrEmpty(txtDuenoEncuesta.Text) || string.IsNullOrEmpty(txtObjetivoEncuesta.Text) || string.IsNullOrEmpty(txtPasswordEncuesta.Password))
                {
                    MessageBox.Show("No ha llenado todos los datos completamente", "Inicio de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Encuestador a = CmbNombreEncuesta.SelectedItem as  Encuestador;
                if (manejadorMesero.BuscarUsuario(a.Id, txtPasswordEncuesta.Password) == true)
                {                  
                    Encuesta enc = new Encuesta() {
                        Duenio = txtDuenoEncuesta.Text,
                        FechaHora = DateTime.Now,
                        Nombre = CmbNombreEncuesta.Text,
                        Objetivo = txtObjetivoEncuesta.Text,
                        // MostrarPreguntasAleatoriamente = txtDuenoEncuesta;
                    };
                    manejadorEncuesta.Agregar(enc);
                    EncuestaFormulario b = new EncuestaFormulario();
                    b.Show();
                    this.Close();

                    b.txtIDMesero.Text = a.Id;
                    b.txtIDEncuesta.Text = enc.Id;
                }
                else {
                    MessageBox.Show("Contraseña incorrecta", "Inicio de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtPasswordEncuesta.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No ha seleccionado ningun usuario\nSeleccione uno", "Inicio de Encuesta", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnConfiguracion_Click(object sender, RoutedEventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Close();
        }
    }
}
