using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto.Movil
{
	
	public partial class pp : ContentPage
	{
		public pp ()
		{
			InitializeComponent ();
            btnPreguntas.Clicked += BtnPreguntas_Clicked;
        }

        private void BtnPreguntas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Encuestar());
        }
    }
}