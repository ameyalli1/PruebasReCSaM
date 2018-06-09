using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto.Movil
{
	
	public partial class Calidad : ContentPage
	{
		public Calidad ()
		{
			InitializeComponent ();
            btnSiguiente.Clicked += BtnSiguiente_Clicked;
            
        }

        private void BtnSiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calidad2());
        }
    }
}