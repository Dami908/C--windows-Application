using Newtonsoft.Json;
using System;
using FacultyLib301050676;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib301050676
{
    [Serializable]
   public class CourseItem : courses
    {
        [JsonProperty]
        protected string Coursecode;
        [JsonProperty]
        protected string Description;
        public string coursecode
        {
            get
            {
                return Coursecode;
            }
            set
            {
                Coursecode = value;

            }
        }
        public string details
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }
        public CourseItem()
        {

        }
        public CourseItem(string itemcoursecode, string Description)
        {
            coursecode = itemcoursecode;
            details = Description;
        }

        public override string ToString()
        {
            string result;
            result = "Course Item: Course: " + coursecode + "\n\t" + "Description: " + details;
            return result;
        }
    }
}