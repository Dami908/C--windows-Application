using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib301050676
{
    class UniqueID
    {
        private static int lastID;
        public static int GetNewId()
        {
            return ++lastID;
        }
    }
}
