using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EFTutorials.Models;

namespace EFTutorials
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDBEntities")
        
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}