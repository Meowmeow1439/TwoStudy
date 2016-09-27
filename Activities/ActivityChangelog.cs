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

namespace TwoStudy.Activities
{
    [Activity(Label = "ActivityChangelog"/*, ParentActivity = typeof(HomeActivity)*/)]
    public class ActivityChangelog : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.changelog);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetDisplayShowHomeEnabled(true);
            ActionBar.SetIcon(Android.Resource.Color.Transparent);
        }
    }
}