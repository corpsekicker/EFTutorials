using System.Collections;
using System.Collections.Generic;

namespace EFTutorials.Models
{
    public class Standard
    {
        public Standard()
        {
            
        }

        public int StandardId { get; set; }

        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}