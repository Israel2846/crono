using System;
using System.Collections.Generic;
using System.Text;
using MySQL.Modelo;

namespace MySQL.Vista_Modelo
{
    public class ControladorUsuario
    {
        public List<Usuario> usuarios{ get; set; }
        public DAOUsuarios crud;
        public ControladorUsuario(string nombre = " ")
        {
            crud = new DAOUsuarios();
            usuarios = crud.ListarUsuarios(nombre);
        }
    }
}
