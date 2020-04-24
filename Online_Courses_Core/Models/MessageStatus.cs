using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Online_Courses_Core.Models
{
    public class MessageStatus
    {
        [Key]
        public int MessageStatusID { get; set; }
        public string Status { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}
