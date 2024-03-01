using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySQL.Modelo
{
    public class DAOPagos
    {
        // Definimos nuestro boleano en falso
        bool b = false;
        // Definimos nuestra cadena
        string sql = string.Empty;
        
        public bool CrearPago (Pago pago, int folio)
        {
            Conexion conexion = new Conexion();
            // Query para insertar
            sql = String.Format("Insert into Pagos values(null, {0}, {1}, '{2}', '{3}')",
                folio, pago.Monto, pago.Fecha, pago.Periodo);
            // Intentamos ejecutar nuestro query
            try
            {
                // Creamos un objeto comando de tipo MySqlCommand con nuestro query y las variables de conexion
                MySqlCommand comando = new MySqlCommand(sql, conexion.Conector());                
                // Ejecutamos nuestro comando
                comando.ExecuteNonQuery(); // Ejecutamos, sirve para todo menos para las consultas                
                // Cambiamos nuestro boleano a verdadero
                b = true;
            }
            catch (Exception excepcion)
            {
                // Mandamos a llamar a la excepcion que se presente
                Console.WriteLine(excepcion.ToString());
                b = false;
            }
            conexion.Desconector();
            return b;
        } // Crear Pago
        
        public List<Pago> ListarPagos(int folio)
        {
            Conexion conexion = new Conexion();
            // Creamos en objeto de tipo lista Pagos llamado pago
            List<Pago> pagos= new List<Pago>();
            // Hacemos nuestro query
            sql = "select * from Pagos where Folio="+folio;
            try
            {
                // Creamos nuestro comando con el query y la conexion
                MySqlCommand comando = new MySqlCommand(sql, conexion.Conector());
                // Creamos un objeto de tipo lector con el lector de nuestro comando
                MySqlDataReader lector = comando.ExecuteReader();
                //Mientras nuestro lector nos de resultados
                while (lector.Read())
                {
                    // Creamos objetos de tipo pago con los datos de nuestra base de datos
                    Pago pago = new Pago
                    {
                        Id_pagos = lector.GetInt32("Id_pagos"),
                        Folio = lector.GetInt32("Folio"),
                        Monto = lector.GetInt32("Monto"),
                        Fecha = lector.GetString("Fecha"),
                        Periodo = lector.GetString("Periodo")
                    };
                    // Agregamos los datos a nuestra lista
                    pagos.Add(pago);
                }
            }  
            catch (Exception excepcion)
            {
                Console.WriteLine (excepcion.ToString());
            }
            conexion.Desconector();
            return pagos;                       
        } // Listar Pagos
        
        public bool ModificarPago(Pago pago)
        {
            Conexion conexion = new Conexion();
            // Query para Modificar
            sql = string.Format("Update Pagos set Monto={0}, Fecha='{1}', Periodo='{2}' Where Id_pagos={3}",
                pago.Monto, pago.Fecha, pago.Periodo, pago.Id_pagos);
            try
            {
                //Creamos un objeto comando de tipo MySqlCommando con nuestro query y las variables de conexion
                MySqlCommand comando = new MySqlCommand(sql, conexion.Conector());
                //Ejecutamos nuestro comando
                comando.ExecuteNonQuery();
                b = true;
            } 
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.ToString());
                b = false;
            }
            conexion.Desconector();
            return b;            
        } // Modificar
        
        public bool EliminarPago(string id)
        {
            Conexion conexion = new Conexion();
            try
            {
                // Creamos un objeto de tipo MySqlCommand llamado comando con el query y la conexion
                MySqlCommand comando = new MySqlCommand("Delete from Pagos where Id_pagos=" + id, conexion.Conector());
                // Ejecutamos el comando
                comando.ExecuteNonQuery();
                b = true;
            }
            catch (Exception excepcion) 
            {
                Console.WriteLine(excepcion.ToString());
                b = false;
            }   
            conexion.Desconector();
            return b;                       
        } // Eliminar        
    } // Clase 
} // Nombre de espacio
