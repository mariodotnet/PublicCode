using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;
using System.Collections.Generic;

namespace TopGoogleNews
{
    [Activity(Label = "TopGoogleNews", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //btn1 click, suma
            ListView lv1 = FindViewById<ListView>(Resource.Id.listView1);

            var items = new List<string>(new[] { "Some item" });
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
            lv1.Adapter = adapter;


        }

    }
}

//[Activity(Label = "BasicTable", MainLauncher = true, Icon = "@drawable/icon")]
//public class HomeScreen : ListActivity
//{
//    string[] items;
//    protected override void OnCreate(Bundle bundle)
//    {
//        base.OnCreate(bundle);
//        items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
//        ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
//    }
//    protected override void OnListItemClick(ListView l, View v, int position, long id) {

//    }
//}

