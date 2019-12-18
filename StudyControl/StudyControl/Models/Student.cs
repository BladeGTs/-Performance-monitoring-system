using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyControl.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string SecondName { get; set; }


        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public string FullName
        {
            get
            {

                return FirstName + " " + SecondName + " " + LastName;
             }
        }
    }
}
