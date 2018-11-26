using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FinalERJP.Dominio;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalERJP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CelularesPage : ContentPage
	{
		public CelularesPage ()
		{
			InitializeComponent ();
		}

        private async void CargarProductos()
        {
            HttpClient comprascel = new HttpClient();
            comprascel.BaseAddress = new Uri("http://192.168.1.80");

            var request = await comprascel.GetAsync("/FinalERMJPH.API/api/Celular");

            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Celular>>(responseJson);
                listCelulares.ItemsSource = listado;
            }
        }

        private async void Celular_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var comprar = e.SelectedItem as Celular;
            await Navigation.PushAsync(new FacturacionPage(comprar));
        }
    }
}