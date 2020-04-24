using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Online_Courses_Core.Models
{
    public class CourseLanguage
    {
        [Key]
        public int CourseLanguageID { get; set; }
        public string Language { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
