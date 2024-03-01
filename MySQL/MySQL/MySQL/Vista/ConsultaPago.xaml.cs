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
    public partial class ConsultaPago : ContentPage
    {
        private int folio;
        public ConsultaPago(int folio)
        {
            this.folio = folio;
            InitializeComponent();
            BindingContext = new ControladorPago(folio);
            RefreshCommand = new Command(ExcecuteRefreshCommand);
            Lista_Pagos.SelectionChanged += Lista_Pagos_SelectionChanged;
        }

        private void Lista_Pagos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pagos = e.CurrentSelection;
            string mensaje = string.Empty;
            for(int i = 0;i< pagos.Count; i++)
            {
                var pago = pagos[i] as Pago;
                Navigation.PushModalAsync(new Vista.AccionesPago(pago));
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
                OnPropertyChanged(nameof(isRefreshing));
            }
        }
        void ExcecuteRefreshCommand()
        {
            isRefreshing = false;
        }

        private void Alta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AltaPago(folio));
        }

        
    }
}