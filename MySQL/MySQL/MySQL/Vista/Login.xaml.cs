using MySQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySQL.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {/*
        DAOUsuarios CrudUsuario= new DAOUsuarios();
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            if(CrudUsuario.ValidarUsuario(EdtCorreo.Text, EdtTelefono.Text) >= 1)
            {
                Navigation.PushModalAsync(new Vista.Inicio());
            }
            else
            {
                DisplayAlert("Error", "Correo o Telefono incorrectas", "Cerrar");
            }
        }
        
        private void BtnRegistrarse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }*/
    }
}