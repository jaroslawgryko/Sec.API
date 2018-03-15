using AutoMapper;
using Sec.API.Dtos;
using Sec.API.Model;

namespace Sec.API.Data
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<LessonForAddDto, Lesson>();

            CreateMap<Lesson, LessonForListDto>();
        }
    }
}