using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1Javier.clases
{
    public class DatabaseHelper
    {

        public DatabaseHelper() { }
        public static bool Insertar<T>(ref T item, string ruta_db)
        {
            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(ruta_db))
            {
                conexion.CreateTable<T>();
                if (conexion.Insert(item) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public static List<Viaje> LeerViajes(String ruta_db)
        {
            List<Viaje> viajes = new List<Viaje>();

            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(ruta_db))
            {
                viajes = conexion.Table<Viaje>().ToList();

            }
            return viajes;
        }



    }
}
