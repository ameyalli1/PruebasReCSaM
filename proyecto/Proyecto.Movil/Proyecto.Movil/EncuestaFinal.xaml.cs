using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto.Movil
{
	
	public partial class EncuestaFinal : ContentPage
	{
		public EncuestaFinal ()
		{
			InitializeComponent ();
            btnTerminar.Clicked += BtnTerminar_Clicked;
		}

        private void BtnTerminar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pp());
        }
    }
}