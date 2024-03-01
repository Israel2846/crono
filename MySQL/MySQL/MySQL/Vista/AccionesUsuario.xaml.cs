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
    public partial class AccionesUsuario : ContentPage
    {
        //Inicializamos nuestro DAO con nombre CrudPersona
        DAOUsuarios crudUsuario= new DAOUsuarios();

        //Inicializamos un objeto de tipo persona
        Usuario usuario;
        public AccionesUsuario(Usuario usuario)
        {
            InitializeComponent();
            TxvFolio.Text = usuario.Folio.ToString();
            EdtFolio.Text = usuario.Folio.ToString();
            EdtNombre.Text = usuario.Nombre.ToString();
            EdtApp.Text = usuario.App.ToString();
            EdtApm.Text = usuario.Apm.ToString();
            EdtCargo.Text = usuario.Cargo.ToString();
            EdtLugarTrabajo.Text = usuario.Lug_trabajo.ToString();
            EdtPuesto.Text = usuario.Puesto.ToString();
            EdtFecha.Text = usuario.Fecha_alta.ToString();
        }
        
        private void BtnModificar_Clicked(object sender, EventArgs e)
        {
            //A nuestra persona le asignamos valores
            usuario = new Usuario
            {
                FolioV = Int16.Parse(TxvFolio.Text),
                Folio = Int16.Parse(EdtFolio.Text),
                Nombre = EdtNombre.Text,
                App = EdtApp.Text,
                Apm = EdtApm.Text,
                Cargo = EdtCargo.Text,
                Lug_trabajo = EdtLugarTrabajo.Text,   
                Puesto = EdtPuesto.Text,
                Fecha_alta = EdtFecha.Text
            };
            //Mensaje usando operador ternario, ademas de crear dentro del string nuestra alta de la persona
            string mensaje = crudUsuario.ModificarUsuario(usuario) ? "Usuario modificado" : "error";

            //Hacemos un DisplayAlert con el mensaje que hicimos
            DisplayAlert("Mensaje", mensaje, "Cerrar");
            Navigation.PushModalAsync(new Vista.Inicio());
        }
        
        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            string mensaje = crudUsuario.EliminarUsuario(TxvFolio.Text) ? "Usuario eliminado" : "Error";
            DisplayAlert("Mensaje", mensaje, "Cerrar");
            Navigation.PushModalAsync(new Vista.Inicio());
        }
    }
}