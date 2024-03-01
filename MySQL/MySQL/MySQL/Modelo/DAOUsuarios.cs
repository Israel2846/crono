using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySQL.Modelo
{
    public class DAOUsuarios
    {
        //Definimos nuestro boleano en falso
        bool b = false;
        //Definimos nuestra cadena
        string sql = string.Empty;
        public bool CrearUsuario ( Usuario usuario )
        {
            Conexion conexion = new Conexion();
            // Query para insertar
            sql = String.Format("Insert into Usuriaos values({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                usuario.Folio, usuario.Nombre, usuario.App, usuario.Apm, usuario.Cargo, usuario.Lug_trabajo, usuario.Puesto, usuario.Fecha_alta);            

            // Intentamos ejecutar nuestro query
            try
            {
                //Creamos un objeto comando de tipo MySqlCommando con nuestro query y las variables de conexion
                MySqlCommand comando = new MySqlCommand(sql, conexion.Conector());                
                //Ejecutamos nuestro comando
                comando.ExecuteNonQuery(); // Ejecutamos, sirve para todo menos las consultas                
                b = true;//Cambiamos nuestro boleano a verdadero
            }
            catch ( Exception excepcion )
            {
                //Mandamos a llamar a la excepcion que se presente
                Console.WriteLine( excepcion.ToString() );
                b = false;
            }
            conexion.Desconector();
            //Retornamos nuestro boleano            
            return b;
        } // Alta de persona
        
        public bool ModificarUsuario(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            // Query para Modificar
            sql = string.Format("Update Usuriaos set Nombre='{0}', App='{1}', Apm='{2}', Lug_trabajo='{3}', Puesto='{4}', Fecha_alta='{5}', Folio={6}, Cargo='{7}' Where Folio={8}",
                usuario.Nombre, usuario.App, usuario.Apm, usuario.Lug_trabajo, usuario.Puesto, usuario.Fecha_alta, usuario.Folio,usuario.Cargo, usuario.FolioV);
            try
            {
                //Creamos un objeto comando de tipo MySqlCommando con nuestro query y las variables de conexion
                MySqlCommand comando = new MySqlCommand(sql, conexion.Conector());
                //Ejecutamos nuestro comando
                comando.ExecuteNonQuery();
                b = true;
            }
            catch( Exception excepcion )
            {
                Console.WriteLine ( excepcion.ToString() );
                b = false;
            }
            conexion.Desconector();
            return b;            
        } // Modificar
        
        public bool EliminarUsuario(string Folio)
        {
            Conexion conexion = new Conexion();
            try
            {
                // Creamos un objeto de tipo MySqlCommand llamado comando con el query y la conexion
                MySqlCommand comando = new MySqlCommand("Delete from Usuriaos where Folio=" + Folio, conexion.Conector());
                // Ejecutamos el comando
                comando.ExecuteNonQuery();
                b = true;
            }
            catch ( Exception excepcion )
            {
                Console.WriteLine(excepcion.ToString());
                b = false;
            }
            conexion.Desconector();
            return b;            
        } // Eliminar

        public List<Usuario> ListarUsuarios(string nombre = " ")
        {
            Conexion conexion = new Conexion();
            // Creamos en objeto de tipo lista Persona llamado persona
            List<Usuario> usuarios = new List<Usuario>();
            // Hacemos nuestro query
            int folio;
            bool esNumero = int.TryParse(nombre, out folio);
            if (esNumero)
            {
                sql = "select * from Usuriaos where Folio =" + folio;                
            }
            else
            {
                sql = "select * from Usuriaos where Nombre LIKE '%" + nombre + "%' or App LIKE '%" + nombre + "%' or Apm LIKE '%" + nombre + "%'";
            }            
            try
            {
                // Creamos nuestro comando con el query y la conexion
                MySqlCommand comando = new MySqlCommand(sql, conexion.Conector());
                // Creamos un objeto de tipo lector con el lector de nuestro comando
                MySqlDataReader lector = comando.ExecuteReader();
                //Mientras nuestro lector nos de resultados
                while (lector.Read())
                {
                    // Creamos objetos de tipo persona con los datos de nuestra base de datos
                    Usuario usuario = new Usuario
                    {
                        Folio = lector.GetInt32("Folio"),
                        Nombre = lector.GetString("Nombre"),
                        App = lector.GetString("App"),
                        Apm = lector.GetString("Apm"),
                        Cargo = lector.GetString("Cargo"),
                        Lug_trabajo = lector.GetString("Lug_trabajo"),
                        Puesto = lector.GetString("Puesto"),
                        Fecha_alta = lector.GetString("Fecha_alta")
                    };
                    // Agregamos los datos a nuestra lista
                    usuarios.Add(usuario);
                } // While      
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conexion.Desconector();
            return usuarios;                       
        } // Listar persona        
    } // Clase
} // Nombre de espacio
