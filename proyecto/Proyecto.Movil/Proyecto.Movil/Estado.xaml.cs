using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto.Movil
{
	
	public partial class Estado : ContentPage
	{
		public Estado ()
		{
			InitializeComponent ();
            btnSiguieente.Clicked += BtnSiguieente_Clicked;

        }

        private void BtnSiguieente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FrecuenciaServicios());
        }
    }
}