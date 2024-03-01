using MySQL.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MySQL
{
    public partial class MainPage : ContentPage
    {/*
        //Inicializamos nuestro DAO con nombre CrudPersona
        DAOUsuarios crudUsuarios= new DAOUsuarios();

        //Inicializamos un objeto de tipo persona
        Usuario usuario;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAlta_Clicked(object sender, EventArgs e)
        {
            //A nuestra persona le asignamos valores
            usuario = new Usuario
            {
                nombre = EdtNombre.Text,
                Apellido_pat = edtApellidoPaterno.Text,
                Apellido_mat = edtApellidoMaterno.Text,
                Num_telefono = edtNumeroTelefono.Text,
                correo_elec = edtCorreo.Text
            };
            //Mensaje usando operador ternario, ademas de crear dentro del string nuestra alta de la persona
            string mensaje = crudUsuarios.CrearUsuario(usuario)?"Usuario dado de alta":"Error";

            //Hacemos un DisplayAlert con el mensaje que hicimos
            DisplayAlert("Mensaje", mensaje, "Cerrar");
            Navigation.PushModalAsync(new Vista.Login());
        } // Boton alta

        
        private void BtnConsultar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Vista.ConsultaUsuario());
        }*/
    }
}
