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
using Xamarin.Forms.Xaml;

namespace Proyecto.Movil
{

	public partial class Edad : ContentPage
    {
        string respuesta = "";
        IManejadorRespuesta manejadorRespuestas;
        public Edad ()
		{
			InitializeComponent ();
            btnSiguiente.Clicked += BtnSiguiente_Clicked;
            manejadorRespuestas = new ManejadorRespuesta(new RepositorioGenerico<Respuesta>());
           // txtNombreEmpleado.Visibility = Visibility.Collapsed;
            //txtNombreEmpresa.Visibility = Visibility.Collapsed;

        }

        private void BtnSiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Estado());
        }
    }
}