using FinalERJP.Dominio;
using FinalERJP.Resources;
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
	public partial class FacturaPage : ContentPage
	{
		public FacturaPage(Celular celular, int valor)
		{
            int total = valor * (celular.Precio);
            InitializeComponent ();
            Layout1.BindingContext = celular;
            vartotal.Text = Convert.ToString(total);
            Label21.Text = Convert.ToString(valor);
            Layout2.BindingContext = celular;
        }

        private void Confirmar(object sender, EventArgs e)
        {
            DisplayAlert(AppResources.Compra, AppResources.Finalizado, AppResources.Continuar);

        }

        private async void Camara_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CamaraPage());
        }

    }
}