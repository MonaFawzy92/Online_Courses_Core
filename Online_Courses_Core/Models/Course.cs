using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public decimal TotalCourseHours { get; set; }
        public string MobileNumber { get; set; }
        public string ImagePath { get; set; }
        public string DemoUrl { get; set; }
        public string CertificateTemplatePath { get; set; }
        public string Description { get; set; }
        public decimal PassPercentage { get; set; }
        public int? CourseStatusID { get; set; }
        [ForeignKey("CourseStatusID")]
        public virtual CourseStatus CourseStatus { get; set; }
        public int? CourseLanguageID { get; set; }
        [ForeignKey("CourseLanguageID")]
        public virtual CourseLanguage CourseLanguage { get; set; }
        public virtual List<CourseFile> Files { get; set; }
        public virtual List<UserCourse> UserCourse { get; set; }
    }
}
