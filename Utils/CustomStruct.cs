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

namespace TwoStudy
{
    public class ActivityItem
    {
        public string Title { get; set; }
        public Intent Intent { get; set; }
        public ActivityItem( string title, Intent intent)
        {
            this.Title = title;
            this.Intent = intent;
        }
        public ActivityItem() { }
        public override string ToString()
        {
            return Title;
        }
    }
}