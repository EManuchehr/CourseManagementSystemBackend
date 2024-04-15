using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping;

public class InstructorProfileMap : Profile
{
    public InstructorProfileMap()
    {
        CreateMap<CreateInstructorRequest, Instructor>();

        CreateMap<Instructor, GetInstructorResponse>();
    }
}