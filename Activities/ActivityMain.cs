using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;

using System.Collections.Generic;

using TwoStudy.Utils;

namespace TwoStudy.Activities
{
    [Activity(Label = "TwoStudy", MainLauncher = true, Icon = "@mipmap/icon")]
    public class HomeActivity : ListActivity
    {
        public ToolsActivity utilFuncActivity = new ToolsActivity();
        public List<ActivityItem> Activities;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Activities = utilFuncActivity.getStartingMenu(this);
            ListAdapter = new ArrayAdapter<ActivityItem>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, Activities);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            StartActivity(Activities[position].Intent);
        }
        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.MenuToolbox, menu);
            return base.OnCreateOptionsMenu(menu);
        }
    }
}
