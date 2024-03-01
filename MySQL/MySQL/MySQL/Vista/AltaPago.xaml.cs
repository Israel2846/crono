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
    public partial class AltaPago : ContentPage
    {
        // Inicializamos nuestro DAO con nombre CrudBateria
        DAOPagos crudPago = new DAOPagos();
        // Inicializamos un objeto de tipo bateria
        Pago pago;
        int Folio;
        public AltaPago(int Folio)
        {
            InitializeComponent();
            this.Folio = Folio;
        }

        private void btnAlta_Clicked(object sender, EventArgs e)
        {
            // A nuestra bateria le asignamos valores
            pago = new Pago
            {
                Monto = Int32.Parse(EdtMonto.Text),
                Fecha = EdtFecha.Text,
                Periodo = EdtPeriodo.Text
            };
            //Mensaje usando operador ternario, ademas de crear dentro del string nuestra alta de bateria
            string mensaje = crudPago.CrearPago(pago, Folio) ? "Pago dado de alta" : "Error";
            Navigation.PushModalAsync(new Vista.Inicio());
            //Display para saber si se dio de alta
            DisplayAlert("Mensaje", mensaje, "Cerrar");
        } // Boton de alta
    } // Clase
} // Nombre de espacio