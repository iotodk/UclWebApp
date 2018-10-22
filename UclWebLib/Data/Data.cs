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
        public static void CreateTeacherLIst()
        {

        }

        public static void GetStudentsAsJson(string filePath)
        {
            //create an empty list of type Student
            List<Student> students = new List<Student>();
            //create 25 mock Students
            for(int i = 0; i < 25; i++)
            {
                Student student = new Student()
                {
                    CPR = 12345678 + i,
                    Name = "Io To" + i,
                    Email = "ioto@ucl.dk",
                    Phone = 23547589 + i,
                    Address = new Address($"Seeblasgade {i}", 5000, "Odense", "Denmark")
                };
                //add each student to the list
                students.Add(student);
            }
            // serialize the list
            var json = JsonConvert.SerializeObject(students);
            System.IO.File.WriteAllText(filePath, json);
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
