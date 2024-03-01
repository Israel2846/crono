using MySQL.Modelo;
using MySQL.Vista_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySQL.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaUsuario : ContentPage
    {
        public ConsultaUsuario(string nombre = "")
        {
            InitializeComponent();
            BindingContext = new ControladorUsuario(nombre);
            RefreshCommand = new Command(ExecuteRefreshCommand);
            Lista_Usuarios.SelectionChanged += Lista_Usuarios_SelectionChanged;
        }

        public ConsultaUsuario()
        {
            InitializeComponent();
            BindingContext = new ControladorUsuario("");
            RefreshCommand = new Command(ExecuteRefreshCommand);
            Lista_Usuarios.SelectionChanged += Lista_Usuarios_SelectionChanged;
        }

        private void Lista_Usuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var usuaarios = e.CurrentSelection;
            string mensaje = string.Empty;
            for (int i = 0; i < usuaarios.Count; i++)
            {
                var usuario = usuaarios[i] as Usuario;
                int folio = usuario.Folio;
                try
                {
                    Navigation.PushModalAsync(new Vista.ConsultaPago(folio));
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "Cerrar");
                }
            }
        }

        public ICommand RefreshCommand { get; }

        bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        void ExecuteRefreshCommand()
        {
            isRefreshing = false;
        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {            
            string nombre = edtBuscar.Text;
            Navigation.PushModalAsync(new Vista.ConsultaUsuario(nombre));
        }
    }
}