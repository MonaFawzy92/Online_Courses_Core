using Online_Courses_Core.Models;
using Online_Courses_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core.AppStart
{
    public class MappingConfig
    {
        public static void RegisterMapps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Course, CourseDto>().ReverseMap().MaxDepth(1);
                config.CreateMap<UserCourse, UserCourseDto>().ReverseMap().MaxDepth(1);
                config.CreateMap<Message, MessageDto>().ReverseMap().MaxDepth(1);
                config.CreateMap<MessageStatus, MessageStatusDto> ().ReverseMap().MaxDepth(1);
                config.CreateMap<User, UserDto>().ReverseMap().MaxDepth(1);
                config.CreateMap<CourseFile, CourseFileDto>().ReverseMap().MaxDepth(1);
                config.CreateMap<CourseStatus, CourseStatusDto>().ReverseMap().MaxDepth(1);
                config.CreateMap<CourseLanguage, CourseLanguageDto>().ReverseMap().MaxDepth(1);

            });
        }
    }
}
