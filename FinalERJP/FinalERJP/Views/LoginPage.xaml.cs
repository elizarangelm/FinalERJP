using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalERJP.Dominio;

using FinalERJP.Resources;

namespace FinalERJP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        async void Login_Clicked(object sender, EventArgs e)
        {
            var usuario = new Login
            {
                Usuario = UsuarioEntry.Text,
                Contraseña = ContraseñaEntry.Text
            };

            var esValido = DatosCorrectos(usuario);
            if (esValido)
            {
                App.ConAcceso = true;
                Navigation.InsertPageBefore(new CelularesPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(AppResources.Compra, AppResources.IntentaloDeNuevo, AppResources.Continuar);
                ContraseñaEntry.Text = string.Empty;
            }
        }

        bool DatosCorrectos(Login usuario)
        {
            return usuario.Usuario == Constantes.Usuario && usuario.Contraseña == Constantes.Contraseña;

        }
    }
}
