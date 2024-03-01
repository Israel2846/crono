using System;
using System.Collections.Generic;
using System.Text;

namespace MySQL.Modelo
{
    public class Pago
    {
        public int Id_pagos { get; set; }
        public int Folio { get;set; }
        public int Monto{ get; set; }
        public string Fecha { get; set; }
        public string Periodo { get; set; }        
    }
}
