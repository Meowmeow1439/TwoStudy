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

using TwoStudy.Activities;

namespace TwoStudy.Utils
{
    public class ToolsActivity
    {
        public List<ActivityItem> getStartingMenu( Android.Content.Context toReturn )
        {
            List<ActivityItem> menuList = new List<ActivityItem>();
            menuList.Add(new ActivityItem("Menu point 1", new Intent(toReturn, typeof( ActivityChangelog ))));
            menuList.Add(new ActivityItem("Menu point 2", null));
            return menuList;
        }
    }
}