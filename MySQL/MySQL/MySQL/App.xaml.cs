using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySQL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new Vista.Inicio();
           //MainPage = new Vista.ModificarUsuario();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
