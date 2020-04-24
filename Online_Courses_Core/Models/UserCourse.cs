using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.Models
{
    public class UserCourse
    {
        [Key, Column(Order = 0)]
        public string UserID { get; set; }
        [Key, Column(Order = 1)]
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public bool IsBookmark { get; set; }
        public DateTime? LastViewed { get; set; }
        public string UserCourseState { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public int? PartsCompleted { get; set; }
        public decimal? AmountPaid { get; set; }
        public string CertificatePath { get; set; }
        public int? UserRate { get; set; }
        public bool IsInstructor { get; set; }
    }
}
