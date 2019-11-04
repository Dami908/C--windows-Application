using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacultyLib;
using FacultyLib301050676;

namespace FacultyLib301050676
{
    public class FacultyRepository:RepositoryBase
    {
        private List<Faculty> Faculty1;
        public override List<Faculty> Faculty
        {
            get
            {
                return Faculty1;
            }
            set
            {
                Faculty1 = value;
            }
        }
        public FacultyRepository()
        {
            Faculty1 = new List<Faculty>();
        }
        public void Add(Faculty customer)
        {
            Faculty1.Add(customer);
        }
        //checks if faculty has an assigned course
        public List<Faculty> FacultyWithNoAssignedCourse()
        {
            List<Faculty> result = new List<Faculty>();
            result = Faculty.Where(customer => customer.Course1.Any(course => course.AssignedCourse == false)).ToList();
            return result;
        }
        // checks if a course is assigned to a faculty between set dates
        public List<Faculty> CustomerWithOrdersBetweenDates(DateTime initialDate, DateTime finalDate)
        {
            List<Faculty> result = new List<Faculty>();
            result = (from faculty in Faculty
                      from course in faculty.Course1
                      where course.EndOfCourse >= initialDate.Date && course.EndOfCourse.Date <= finalDate
                      select faculty).ToList();
            result = result.Distinct().ToList();
            return result;
        }
        
                    
        
    }
}
