using System;
using System.Collections.Generic;
using System.Text;

namespace App1Javier.clases.Halper
{
   public class Constants
    {


        public const string CLIENT_ID = "EP20QGPO2GLBXVZRIDOJM5VRT3TEPSLPKAY1LDADKALHDKAR";
        public const string CLIENT_SECRET = "ZJ5S24PS0UJTILN4TVY1QVWZFAUJYRRHLYKZHOU2ZVSI1QIN";
        public static string ObtenerUrlCategorias() {
            return $"https://api.foursquare.com/v2/venues/categories?client_id={CLIENT_ID}&client_secret={CLIENT_SECRET}&v={DateTime.Now.ToString("yyyyMMdd")}";
        } 
        //public const string CLIENT_ID = "";
    }
}
