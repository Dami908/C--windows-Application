using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyLib
{
    public struct Address
    {
        //Emmanuel Ajayi----301050676
        private string street;
        private string city;
        private string province;
        private string postalcode;

        public Address(string str,string cit,string pro):this()
        {
            Street = str;
            City = cit;
            Province = pro;
            
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Province
        {
            get
            {
                return province;
            }
            set
            {
                province = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return postalcode;
            }
            set
            {
                postalcode = value;
            }
        }
        public string GetInfo()
        {
            return $"{Street},{City},{Province},{PostalCode}";
        }
    }
}
