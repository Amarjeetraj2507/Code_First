using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CodeFirstModel.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Student Name required")]
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
    }
}