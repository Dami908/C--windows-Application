using FacultyLib301050676;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib
{
    [Serializable]
    public class Faculty
    {
        //Emmanuel Ajayi------301050676
        private int employeeNumber;
        private uint empID;
        private string name;
        private DateTime employmentDate;
        private static uint idCount;
        private ulong phoneNumber;
        public Address Address1;
        private string[] email;
        private Course[] courses;
        private int noOfEmails;
        private int noOfcourses;
        private List<Course> course1;

        public Faculty(string nam, uint id,Address add, ulong phone)
        {
            course1 = new List<Course>();
            Name = nam;
            EmpID = id;
            phoneNumber = phone;
            Address=add;
            email = new string[15];
            courses = new Course[15];
            
        }
        public Faculty()
        {
            course1 = new List<Course>();
            idCount++;
            EmpID = idCount;
            email = new string[15];
            courses = new Course[15];
            EmployeeNumber = UniqueID.GetNewId();
        }
       

        static Faculty()
        {
            idCount = 0;
        }

        [JsonProperty]
        public List<Course> Course1
        {
            get
            {
                return course1;
            }
            set
            {
                course1 = value;
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

        public int EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }
        public uint EmpID
        {
            get
            {
                return empID;
            }
            set { empID = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Course AddCourse(Course course)
        {
            course.Faculty = this;
            Course1.Add(course);
            return Course1.LastOrDefault();
        }
        public DateTime StartOfEmployment
        {
            get
            {
                return employmentDate;
            }
            set
            {
                employmentDate = value;
            }
        }
        public ulong TelephonNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value < 9999999999)
                {
                    phoneNumber = value;
                }
                else
                {
                    phoneNumber = 0;
                }

            }
        }
        public Address Address
        {
            get
            {
                return Address1;
            }
            set
            {
                Address1 = value;
            }
        }
        public string[] Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }
      
        [JsonProperty]
        public Course[] Course
        {
            get
            {
                return courses;
            }
            

        }
        public void AddEmail(string emails)
        {
            Email[noOfEmails++] =  emails;
           


        }
        public void AddQualifiedCourse(Course course1)
        {
            Course[noOfcourses++] = course1;
        }
        public bool IsQualified(string courseCode)
        {
            bool isQualified = false;
            foreach(Course c in Course)
            {
                if(c!=null && c.CourseCode == courseCode)
                {
                    isQualified = true;
                }
            }
            return isQualified;
        }
        
        public override string ToString()
        {
            string result= $"Faculty:\nEmployee Number: {EmpID} , Faculty Name: {Name} , \tStart of Employment: {StartOfEmployment} ";
            result += $"\nFaculty emails:\n";
            for (int i = 0; i < noOfEmails; i++)
            {
                result += $"{Email[i]}";
            }

            result += $"\nAssigned Course: ";
            for(int i = 0; i < noOfcourses; i++)
            {
                result += "\n" + Course[i].ToString();

            }
            
                return result; 
        }
    }
}
