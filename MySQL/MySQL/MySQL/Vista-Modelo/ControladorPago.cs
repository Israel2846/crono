using MySQL.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySQL.Vista_Modelo
{
    public class ControladorPago
    {
        public List<Pago> pagos {  get; set; }
        public DAOPagos crud;        
        public ControladorPago(int folio)
        {
            crud = new DAOPagos();
            pagos = crud.ListarPagos(folio);
        }
    }
}
