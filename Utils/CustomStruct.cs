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
    #region ActivityItem
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
    #endregion
    #region Lesson
    public class Lesson
    {
        public Teacher teacher;
        public string subjectName;
        public List<string> time;
        public string location;
        //public int lessonPosition;
        //public int teacherId;
        //public int subjectId;

        public Lesson( int subjectId, int teacherId, int lessonPosition, int locationId )
        {
            //this.lessonPosition = lessonPosition;
            //this.subjectId = subjectId;
            //this.teacherId = teacherId;
            time = new ToolsSchedule().getTimeByPosition(lessonPosition);
            location = new ToolsSchedule().getLocationById(locationId);
            teacher = new ToolsTeacher().getTeacherById(teacherId);
        }

    }
    #endregion
    #region Teacher
    public class Teacher
    {
        string Surname, Name, Name2;
        int id;
        public Teacher( string Surname, string Name, string Name2)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Name2 = Name2;
        }
    }
    #endregion
}