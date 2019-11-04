using Newtonsoft.Json;
using FacultyLib301050676;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib
{
    [Serializable]
     public class Course
    {


        //Emmanuel Ajayi----301050676
        private uint number;
        private static uint idCount;
        private string title;
        public CourseSubject Subject;
        private Faculty faculty;
        private bool assignCourse;
        private DateTime courseAssignTime;
        private DateTime endOfCourse;
        private List<NewCourseList> items;
        

        CourseSubject Code = CourseSubject.BSAF;

        public Course(CourseSubject cname, uint num,string title1)
        {
            items = new List<NewCourseList>();
            idCount++;
            Number = idCount;
            Number = num;
            Title = title1;
            Code = cname;
        }
        [JsonIgnore]
        public Faculty Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                if (faculty == null)
                {
                    faculty = value;
                }
                else
                {
                    Console.WriteLine("Something went wrong!");
                }
            }
        }
        public DateTime EndOfCourse
        {
            get
            {
                return endOfCourse;
            }
            set
            {
                endOfCourse = value;
            }
        }
        public static uint IdCount
        {
            set
            {
                if (value == idCount - 1)
                {
                    idCount = value;
                }
            }
            get
            {
                return idCount;
            }
        }
        static Course()
        {
            idCount = 0;
        }
        public bool AssignedCourse
        {
            get
            {
                return assignCourse;
            }
            set
            {
                assignCourse = value;
                if (value == true)
                {
                    CourseAssignTime = DateTime.Now;
                }
                else if (value == false)
                {
                    courseAssignTime = DateTime.MinValue;
                }
            }
        }
        public DateTime CourseAssignTime
        {
            get
            {
                return courseAssignTime;
            }
            set
            {
                courseAssignTime = value;
            }
        }


        public List<NewCourseList> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
        public NewCourseList AddCourseItem(courses item)
        {
            this.Title = item.details;
            this.Title = item.coursecode;
            Items.Add(new NewCourseList(item));
            return Items.LastOrDefault();
        }

        public Course()
        {
            items = new List<NewCourseList>();
            Number = idCount;
            idCount++;
        }

       
        public uint Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string CourseCode
        {
            get
            {
                string result = $"{Title} ";
                return result;
            }
        }
        public override string ToString()
        {
            return $"Course: {CourseCode}";
            //return Title;

        }

    }
}
