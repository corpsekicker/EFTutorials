using EFTutorials.Models;

namespace EFTutorials.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFTutorials.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFTutorials.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            // Add a Teacher
            Teacher teacher = new Teacher { TeacherId = 1, Name = "Teacher 1" };
            context.Teachers.Add(teacher);
            context.SaveChanges();

            // Add a Standard
            Standard standard1 = new Standard { StandardId = 1, StandardName = "Standard 1" };
            context.Standards.Add(standard1);
            context.SaveChanges();

            // Add a Student
            Student student = new Student { StudentName = "New Student", Standard = standard1 };
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
