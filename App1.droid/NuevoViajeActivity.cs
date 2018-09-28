using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using App1Javier.clases;

namespace App1.droid
{
    [Activity(Label = "NuevoViajeActivity")]
    public class NuevoViajeActivity : Activity
    {
        EditText lugar;
        DatePicker ida, regreso;
        Button guardar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.NuevoViaje);

            lugar = FindViewById<EditText>(Resource.Id.lugare);
            ida = FindViewById<DatePicker>(Resource.Id.idadate);
            regreso = FindViewById<DatePicker>(Resource.Id.regresodate);
            guardar = FindViewById<Button>(Resource.Id.grabargo);

            guardar.Click += guardarBoton;
        }

        private void guardarBoton(object sender, EventArgs e)
        {
            string nombreArchivo = "viajes_db.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string ruta = Path.Combine(rutaCarpeta, nombreArchivo);
            var nuevoviaje = new Viaje()
            {
                Nombre= lugar.Text,
                FechaInicio=ida.DateTime,
                FechaRegreso=ida.DateTime

            };

            if (DatabaseHelper.Insertar(ref nuevoviaje, ruta)) {
                Toast.MakeText(this, "Registro Insertado correctamente", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Hubo un Error", ToastLength.Short).Show();
            }

        }
    }
}