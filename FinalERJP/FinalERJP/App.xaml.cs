using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalERJP.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FinalERJP
{
    public partial class App : Application
    {
        public static bool ConAcceso { get; set; }
        public App()
        {

            if (!ConAcceso)
            {
                MainPage = new NavigationPage(new LoginPage());
               
               
            }
            else
            {
                MainPage = new NavigationPage(new CelularesPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
