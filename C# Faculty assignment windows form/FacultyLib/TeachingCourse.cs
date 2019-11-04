using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib
{   
    public class TeachingCourse
    {
        //Emmanuel Ajayi-----301050676
        private String courseCode;
        private Faculty faculty;
        private DateTime startDate;
        private DateTime endDate;
        private Course Course;
        
        private bool canceled;

        public TeachingCourse(Course newCourse, DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            CourseCode = newCourse.CourseCode;
            //make property
            Course = newCourse;

            
            
        }

        public TeachingCourse(Course course,Faculty faculty, DateTime start,DateTime end)
        {
            CourseCode = course.CourseCode;
            Faculty = faculty;
            Startdate = start;
            Enddate = end;
           
           
        }
        

       
        public String CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }
        public Faculty Faculty
        {
            get
            {
                return faculty;
            }
            private set
            {
                faculty = value;
            }
        }
        public DateTime Startdate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public DateTime Enddate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public bool Canceled
        {
            get
            {
                return canceled;
            }
            set
            {
                canceled = value;
            }
        }
        public void AssignFaculty(Faculty facultyassigned)
        {
            foreach (Course course in facultyassigned.Course)
            {
                if (course != null)
                {
                    if (facultyassigned.IsQualified(CourseCode) == true)//.CourseCode == this.CourseCode)
                    {
                        faculty = facultyassigned;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{facultyassigned.Name} is not assigned to teach{CourseCode}");
                    }
                }
                
            }           
        }

        public override string ToString()
        {
            if (faculty!=null)
            {
                return $"Teaching Course:\nCourse Code:{CourseCode} ,  Start Date: {Startdate},End Date: {Enddate},";

            }
            else
            {
                return $"{CourseCode},0,Faculty not assigned, Startdate:{Startdate}, End Date{Enddate}";
            }
            

      
        }
    }
}
