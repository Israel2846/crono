using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using Java.Lang.Reflect;

namespace MySQL.Droid
{
    public class Conexion
    {
        public MySqlConnection conexion;
        public bool TryConnection(Context context)
        {
            MySqlConnectionStringBuilder Constructor = new MySqlConnectionStringBuilder();
            Constructor.Port = 3306;
            Constructor.Server = "sql9.freemysqlhosting.net"; //Al ser una BD Online debes usar la ip de tu servidor y no localhost
            Constructor.Database = "sql9615317";
            Constructor.UserID = "sql9615317"; //Es el usuario de la base de datos
            Constructor.Password = "NXrlyTdG3u";
            try
            {
                conexion = new MySqlConnection(Constructor.ToString());
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }
        }
    }
}