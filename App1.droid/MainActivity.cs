using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace App1.droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText nom, pass;
        Button iniciar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.activity_main);

            nom = FindViewById<EditText>(Resource.Id.nom);

            pass = FindViewById<EditText>(Resource.Id.pass);

            iniciar = FindViewById<Button>(Resource.Id.go);

            iniciar.Click += iniciosesion;

          
        }

        private void iniciosesion(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(nom.Text) || !string.IsNullOrEmpty(pass.Text))
            {
                Intent intent = new Intent(this, typeof(ListaViajesActivity));
                StartActivity(intent);
            }
            else
            {
                Toast.MakeText(this, "Casillas Vacias", ToastLength.Short).Show();
            }
         
        }
    }
}