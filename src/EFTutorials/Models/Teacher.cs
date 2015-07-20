using System.Collections;
using System.Collections.Generic;

namespace EFTutorials.Models
{
    public class Teacher
    {
        public Teacher()
        {
            
        }

        public int TeacherId { get; set; }
        
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}