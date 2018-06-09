using Proyecto.BIZ;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using Proyecto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto.Movil
{
	public partial class MainPage : ContentPage
	{
        IManejadorMesero manejadorMeseros;
        IManejadorEmpresa manejadorEmpresa;

        public MainPage()
		{

			InitializeComponent();
            manejadorMeseros = new ManejadorMesero(new RepositorioGenerico<Encuestador>());
            manejadorEmpresa = new ManejadorEmpresa(new RepositorioGenerico<Empresa>());
            // este es para todos los botones 
            btnIngresar.Clicked += BtnIngresar_Clicked;
		}

        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {

            //para cambiar de ventana
            Navigation.PushAsync (new pp());

           /* if (string.IsNullOrEmpty(cmbEmpresa))
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
            */
        }
        
    }
}
