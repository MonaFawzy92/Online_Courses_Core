using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.ViewModels
{
    public class CourseFileDto
    {
        public int CourseFileID { get; set; }
        public int PartNumber { get; set; }
        public string FilePath { get; set; }
        public string VideoPath { get; set; }
        public int? CourseID { get; set; }
    }
}
