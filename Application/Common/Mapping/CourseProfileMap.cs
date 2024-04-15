using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping;

public class CourseProfileMap : Profile
{
    public CourseProfileMap()
    {
        CreateMap<CreateCourseRequest, Course>();

        CreateMap<Course, GetCourseResponse>()
            .ForMember(x => x.Instructor, opt =>
                opt.MapFrom(src => src.Instructor));

        CreateMap<Course, GetAllCourseResponse>()
            .ForMember(x => x.Instructor, opt =>
                opt.MapFrom(src => src.Instructor));
    }
}