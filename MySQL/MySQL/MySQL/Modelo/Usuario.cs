using System;
using System.Collections.Generic;
using System.Text;

namespace MySQL.Modelo
{
    public class Usuario
    {
        public int Folio { get; set; }
        public int FolioV { get; set; }
        public string Nombre { get; set; }
        public string App { get; set;}
        public string Apm { get; set; }
        public string Cargo { get; set; }
        public string Lug_trabajo { get; set; }
        public string Puesto{ get; set; }
        public string Fecha_alta { get; set; }
    }
}
