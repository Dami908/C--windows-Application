using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib301050676
{
    [Serializable]
    public class NewCourseList
    {
        private courses item;

        public courses Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
        public NewCourseList(courses item)
        {
            Item = item;
        }

        public override string ToString()
        {
            string result;
            result = Item.coursecode + " - " + Item.details;
            return result;
        }
    }
}
