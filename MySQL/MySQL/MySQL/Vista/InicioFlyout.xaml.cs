using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySQL.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioFlyout : ContentPage
    {
        public ListView ListView;

        public InicioFlyout()
        {
            InitializeComponent();

            BindingContext = new InicioFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class InicioFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<InicioFlyoutMenuItem> MenuItems { get; set; }
            
            public InicioFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<InicioFlyoutMenuItem>(new[]
                {
                    new InicioFlyoutMenuItem { Id = 0, Title = "Alta", TargetType = typeof(AltaUsuario) },
                    //new InicioFlyoutMenuItem { Id = 1, Title = "Consulta", TargetType = typeof(ConsultaUsuario) },
                    new InicioFlyoutMenuItem { Id = 2, Title = "Modificar", TargetType = typeof(ModificarUsuario) },                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}