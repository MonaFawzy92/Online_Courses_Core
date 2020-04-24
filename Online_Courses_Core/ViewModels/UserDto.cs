using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.ViewModels
{
    public class UserDto
    {
        public string Id { get; set; }
        public bool IsApproved { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string MobileNumber { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public List<UserCourseDto> UserCourse { get; set; }
    }
}
