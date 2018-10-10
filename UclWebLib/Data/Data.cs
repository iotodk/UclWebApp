using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UclWebLib.Objects;

namespace UclWebLib.Data
{
    public static class Data
    {

        public static string GetStudentsAsJson(string filePath)
        {
            //TODO
            //read the file
            //parse it
            //return it
            return string.Empty;
        }

        public static string GetStudentAsJson()
        {
            Student student = new Student()
            {
                CPR = 12345678,
                Name = "Io To",
                Email = "ioto@ucl.dk",
                Phone = 23547589,
                Address = new Address("Seeblasgade 1", 5000, "Odense", "Denmark")
            };
            return JsonConvert.SerializeObject(student);
        }
    }
}
