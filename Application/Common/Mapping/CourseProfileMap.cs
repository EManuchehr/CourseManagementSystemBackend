using AutoMapper;
using Contracts.Requests;
using Domain.Entities;

namespace Application.Common.Mapping;

public class CourseProfileMap : Profile
{
    public CourseProfileMap()
    {
        CreateMap<CreateCourseRequest, Course>();
    }
}