using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.ViewModels
{
    public class MessageDto
    {
        public int MessageID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string MessageBody { get; set; }
        public DateTime? DateSent { get; set; }
        public int CustomMessageID { get; set; }
        public int? MessageStatusID { get; set; }
        public MessageStatusDto MessageStatus { get; set; }
    }
}
