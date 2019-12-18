using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudyControl.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LecTime { get; set; }
        public string LabTime { get; set; }
        public string Practice { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
