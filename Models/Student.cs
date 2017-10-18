using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LawsonU.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Student's Name")]
        public string Name { get; set; } 
        public DateTime Birthday { get; set; }
        [DisplayName("Enrollment Date")]
        public DateTime Enrollment_Date { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
