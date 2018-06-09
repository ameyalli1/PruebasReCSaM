using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto.Movil
{
	
	public partial class Encuestar : ContentPage
	{
		public Encuestar ()
		{
			InitializeComponent ();
            btnVerPoliticas.Clicked += BtnVerPoliticas_Clicked;
            btnSiguiente.Clicked += BtnSiguiente_Clicked;
        }

        private void BtnSiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Edad());
        }

        private void BtnVerPoliticas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Politicas());
        }
    }
}