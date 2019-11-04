using System;
using System.Collections.Generic;
using System.IO;
using FacultyLib301050676;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FacultyLib
{
    public abstract class RepositoryBase
    {
        public abstract List<Faculty> Faculty { get; set; }

        //private Faculty[] faculties;

        //public Faculty[] Faculties
        //{
        //    get { return faculties; }
        //    set { faculties = value; }
        //}
        

        //public RepositoryBase()
        //{
        //    faculties = new Faculty[10];
            
        //}

        public void Save(string filename)
        {
            FileStream fileout = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileout);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.All });
            serializer.Serialize(writer, Faculty);
            writer.Close();
            fileout.Close();

        }
        public void Load(string filename)
        {

            FileStream fileIn = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileIn);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });
            Faculty = serializer.Deserialize(reader, typeof(List<Faculty>)) as List<Faculty>;
            reader.Close();
            fileIn.Close();

            foreach (Faculty customer in Faculty)
            {
                if (customer != null)
                {
                    foreach (Course order in customer.Course1)
                    {
                        if (order != null)
                        {
                            order.Faculty = customer;
                        }
                    }
                }
            }
        }
    }
}
