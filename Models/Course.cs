using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LawsonU.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Course Title")]
        public string Course_Title { get; set; }
        [DisplayName("Credit Hours")]
        public double Credit_Hours { get; set; }
        public string Description { get; set; }
        [DisplayName("Class Size")]
        public int Class_Size { get; set; }
        [DisplayName("Passing Percentage")]
        public double Passing_Percentage { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}