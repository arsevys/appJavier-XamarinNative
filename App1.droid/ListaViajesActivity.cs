using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1Javier.clases;

namespace App1.droid
{
    [Activity(Label = "ListaViajesActivity")]
    public class ListaViajesActivity : ListActivity
    {
      static  string nombreArchivo = "viajes_db.sqlite";
      static  string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        string ruta = Path.Combine(rutaCarpeta, nombreArchivo);
        List<Viaje> viajes;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
       

            viajes = new List<Viaje>();
            viajes = DatabaseHelper.LeerViajes(ruta);

            var arrayAdapter = new ArrayAdapter(this,Android.Resource.Layout.SimpleListItem1,viajes);
            ListAdapter = arrayAdapter;
        }

        protected override void OnRestart()
        {
            base.OnRestart();
      
            viajes = new List<Viaje>();
            viajes = DatabaseHelper.LeerViajes(ruta);

            var arrayAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, viajes);
            ListAdapter = arrayAdapter;

        }
    }
}