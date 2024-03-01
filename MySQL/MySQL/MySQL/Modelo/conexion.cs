using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace MySQL.Modelo
{
    public class Conexion
    {
        public MySqlConnection conector = null;
        public MySqlConnection Conector()
        {
            MySqlConnectionStringBuilder Constructor = new MySqlConnectionStringBuilder();
            Constructor.Port = 3306;
            Constructor.Server = "sql9.freemysqlhosting.net"; //Al ser una BD Online debes usar la ip de tu servidor y no localhost
            Constructor.Database = "sql9615317";
            Constructor.UserID = "sql9615317"; //Es el usuario de la base de datos
            Constructor.Password = "NXrlyTdG3u";
            try
            {
                conector = new MySqlConnection(Constructor.ToString());                
                conector.Open();                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }            
            return conector;                              
        }
        public MySqlConnection Desconector()
        {
            conector.Close();
            return conector;
        }
    } // Clase
} // Nombre de espacio
