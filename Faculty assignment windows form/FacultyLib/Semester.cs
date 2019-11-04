using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib
{
     public class Semester
    {
        //Emmanuel Ajayi---301050676
        
        private int schoolYear;
        private TeachingCourse[] coursesOffered;

        SemesterTime season = SemesterTime.WINTER;
        private int numberOfCourses;

        public Semester(SemesterTime sname,int date)
        {
            season = sname;
            SchoolYear = date;
            coursesOffered = new TeachingCourse[10];
        }

        public Semester()
        {
            coursesOffered = new TeachingCourse[10];
        }


        public int SchoolYear
        {
            get
            {
                return schoolYear;
            }
            set
            {
                schoolYear = value;
            }
        }
        public TeachingCourse[] CoursesOffered
        {
            get
            {
                return coursesOffered;
            }
        }

        public SemesterTime SemesterTime { get; set; }

        public void AddTeachingCourse(Course course, DateTime startDate, DateTime endDate)
        {
            TeachingCourse teachingCourse = new TeachingCourse(course,  startDate, endDate);
            coursesOffered[numberOfCourses++] = teachingCourse;
        }
        public override string ToString()
        {
            string result=$"Semester:\nschoolyear: {schoolYear} season:{season}";
            result += $"\nTeaching Course: ";
            for (int i = 0; i < numberOfCourses; i++)
            {
                result += "\n" + coursesOffered[i].ToString();

            }
            return result;


        }
    }
}
