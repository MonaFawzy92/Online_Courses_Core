using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.Models
{
    public class User : IdentityUser
    {
        [Key]
        public bool IsApproved { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string MobileNumber { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public virtual List<UserCourse> UserCourse { get; set; }
    }
}
