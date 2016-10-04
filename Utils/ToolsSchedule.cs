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
    class ToolsSchedule
    {
        public List<string> getTimeByPosition( int position)
        {
            switch( position)
            {
                case 1: return new List<string> { "8:00", "8:45" };
                case 2: return new List<string> { "9:00", "9:45" };
                case 3: return new List<string> { "10:05", "10:50" };
                case 4: return new List<string> { "11:10", "11:55" };
                case 5: return new List<string> { "12:10", "12:55" };

                default: return new List<string> { "ERR0R", "ERR0R" };
            }
        }

        public string getLocationById(int id)
        {
            switch (id)
            {
                case 1: return "11-A";
                case 2: return "11-Á";

                default: return "ERR0R";
            }
        }

    }
}