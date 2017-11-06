using Android.App;
using Android.Widget;
using Android.OS;

namespace EjemploCalculadora
{
    [Activity(Label = "EjemploCalculadora", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //btn1 click, suma
            Button b1 = FindViewById<Button>(Resource.Id.button1);
            b1.Click += B1_Click;
        }

        //Handles click
        private void B1_Click(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView r = FindViewById<TextView>(Resource.Id.textView3);

            r.Text = (int.Parse(input1.Text) + int.Parse(input2.Text)).ToString();
        }
    }


}

