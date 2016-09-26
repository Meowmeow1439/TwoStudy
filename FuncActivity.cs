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

namespace TwoStudy.Utils
{
    public class FuncActivity
    {
        public List<ActivityItem> getStartingMenu()
        {
            List<ActivityItem> menuList = new List<ActivityItem>();
            menuList.Add(new ActivityItem("Menu point 1", null/*new Intent(this, typeof( "axml file name" ))*/));
            menuList.Add(new ActivityItem("Menu point 2", null));
            return menuList;
        }
    }
}