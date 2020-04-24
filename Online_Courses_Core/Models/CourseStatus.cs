using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Online_Courses_Core.Models
{
    public class CourseStatus
    {
        [Key]
        public int CourseStatusID { get; set; }
        public string Status { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
