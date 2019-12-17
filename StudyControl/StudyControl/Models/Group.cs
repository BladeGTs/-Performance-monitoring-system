using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudyControl.Models
{
    public class Group
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string NumberGroup { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
