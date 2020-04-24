using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.ViewModels
{
    public class UserCourseDto
    {
        public string UserID { get; set; }
        public int CourseID { get; set; }
        public CourseDto Course { get; set; }
        public UserDto User { get; set; }
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
