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
    public partial class AccionesPago : ContentPage
    {
        //Inicializamos nuestro DAO con nombre CrudBateria
        DAOPagos crud = new DAOPagos();
        //Inicializamos un objeto de tipo bateria
        Pago pago;
        public AccionesPago(Pago pago)
        {
            InitializeComponent();
            TxvId.Text = pago.Id_pagos.ToString();
            TxvFolio.Text = pago.Folio.ToString();
            EdtMonto.Text = pago.Monto.ToString();
            EdtFecha.Text = pago.Fecha.ToString();
            EdtPeriodo.Text = pago.Periodo.ToString();                     
        }
        
        private void btnModificar_Clicked(object sender, EventArgs e)
        {
            // A nuestra bateria le asignamos valores
            pago = new Pago
            {
                Id_pagos = Int32.Parse(TxvId.Text),
                Folio = Int32.Parse(TxvFolio.Text),
                Monto = Int32.Parse(EdtMonto.Text),
                Fecha = EdtFecha.Text,
                Periodo = EdtPeriodo.Text
            };
            // Mensaje usando el operador ternario , ademas de crear dentro del string nuestra alta de la persona
            string mensaje = crud.ModificarPago(pago) ? "Pago modificado" : "Error";
            // Hacemos un display alert con el mensaje que hicimos
            DisplayAlert("Mensaje", mensaje, "Cerrar");
            Navigation.PushModalAsync(new Vista.Inicio());
;        }
        
        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            string mensaje = crud.EliminarPago(TxvId.Text) ? "Pago eliminado" : "Error";
            DisplayAlert("Mensaje", mensaje, "Cerrar");            
            Navigation.PushModalAsync(new Vista.Inicio());
        }
    }
}