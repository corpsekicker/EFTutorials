using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTutorials.Models;

namespace EFTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = new SchoolContext())
            {
                // Add a Teacher
                //Teacher teacher = new Teacher {Name = "Teacher 1"};

                // Add a Standard
                Standard standard1 = new Standard { StandardId = 1, StandardName = "Standard 1" };
                context.Standards.Add(standard1);
                context.SaveChanges();

                // Add a Student
                Student student = new Student { StudentName = "New Student", Standard = standard1 };
                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
