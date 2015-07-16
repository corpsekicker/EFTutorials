using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTutorials;

namespace EFBasicTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolDBEntities context = new SchoolDBEntities())
            {
                Student studentEntity = context.Students.FirstOrDefault<Student>();
                var entityType = ObjectContext.GetObjectType(studentEntity.GetType());


                Console.WriteLine("Student Entity Type: " + entityType);
                Console.WriteLine("Student Standard: " + studentEntity.Standard.StandardName);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
