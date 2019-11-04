using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib
{
     public class CECourse
    {
        private int number;
        private string title;
        public CourseSubject subject;
        private int breakEvenEnrolement;

        CourseSubject Code = CourseSubject.BSAF;

        public CECourse(CourseSubject cname, int num, string title1, int bre)
        {
            Number = num;
            Title = title1;
            Code = cname;
            BreakEvenEnrolement = bre;
        }

        public int Number
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
        public int BreakEvenEnrolement
        {
            get
            {
                return breakEvenEnrolement;
            }
            set
            {
                breakEvenEnrolement = value;
            }
        }
        public override string ToString()
        {
            return $"Course:\nCourse number: {Number} , Course title: {Title} course code:{Code}, BreakEvenEnrolement:{BreakEvenEnrolement}";


        }
    }
}
