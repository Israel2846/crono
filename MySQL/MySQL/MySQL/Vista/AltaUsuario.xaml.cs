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
    public partial class AltaUsuario : ContentPage
    {
        //Inicializamos nuestro DAO con nombre CrudUsuario
        DAOUsuarios crudUsuarios = new DAOUsuarios();

        //Inicializamos un objeto de tipo usuario
        Usuario usuario;
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void BtnAlta_Clicked(object sender, EventArgs e)
        {
            //A nuestro usuario le asignamos valores
            usuario = new Usuario
            {
                Folio = Int32.Parse(EdtFolio.Text),
                Nombre = EdtNombre.Text,
                App = EdtApp.Text,
                Apm = EdtApm.Text,
                Cargo = EdtCargo.Text,
                Lug_trabajo = EdtLugarTrabajo.Text,
                Puesto = EdtPuesto.Text,
                Fecha_alta = EdtFecha.Text
            };
            //Entramos en el Try para intentar dar de alta a la persona
            try
            {
                //Mensaje usando operador ternario, ademas de crear dentro del string nuestra alta de la persona
                string mensaje = crudUsuarios.CrearUsuario(usuario) ? "Usuario dado de alta" : "Error";

                //Hacemos un DisplayAlert con el mensaje que hicimos
                DisplayAlert("Mensaje", mensaje, "Cerrar");
                //Regresamos a la misma pagina para refrescar
                Navigation.PushModalAsync(new Vista.AltaUsuario());
            }
            //En caso de haber una excepción
            catch (Exception ex)
            {
                //Mandamos un display alert con el error que nos está mandando
                DisplayAlert("Mensaje", ex.Message, "Cerrar");                
            }
        }
    }
}