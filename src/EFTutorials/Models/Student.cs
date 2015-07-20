using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTutorials.Models
{
    public class Student
    {
        public Student()
        {
            //this.DateOfBirth = DateTime.Now;
        }

        public int StudentID { get; set; }

         public string StudentName { get; set; }
        [Column("DateOfBirth", TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        
        public int? StandardId { get; set; }
        //public int TeacherId { get; set; }

       //public Teacher Teacher { get; set; }
        public Standard Standard { get; set; }
    }
}