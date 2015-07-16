using System.Data.Entity;
using EFTutorials.Models;

namespace EFTutorials
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}