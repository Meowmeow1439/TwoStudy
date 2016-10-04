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
    class ToolsTeacher
    {
         public Teacher getTeacherById( int id)
        {
            switch( id)
            {
                case 0: return new Teacher("Test11", "Test12", "Test13");
                case 1: return new Teacher("Test21", "Test22", "Test23");
                default: return null;
            }
        }
    }
}