using FinalERJP.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalERJP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FacturacionPage : ContentPage
	{
        Celular globalcelulares;
        public FacturacionPage (Celular celular)
		{
			InitializeComponent ();
            BindingContext = celular;
            globalcelulares = celular;
        }
      

        private async void Continuar_Clicked(object sender, EventArgs e)
        {

            int valor = Convert.ToInt32(valorEntry.Text);
            await Navigation.PushAsync(new FacturaPage(globalcelulares, valor));
        }
    }
}