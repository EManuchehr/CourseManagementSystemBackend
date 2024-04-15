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

        CreateMap<Course, GetCourseResponse>();

        CreateMap<Course, GetAllCourseResponse>();
    }
}