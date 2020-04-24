using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Online_Courses_Core.Models
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string MessageBody { get; set; }
        public DateTime? DateSent { get; set; }
        public int CustomMessageID { get; set; }
        public int? MessageStatusID { get; set; }
        [ForeignKey("MessageStatusID")]
        public virtual MessageStatus MessageStatus { get; set; }
    }
}
