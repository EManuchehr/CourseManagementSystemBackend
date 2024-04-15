using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController(IBaseService<Course> courseService, IMapper mapper) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCourseRequest request, CancellationToken token)
    {
        await courseService.CreateAsync(mapper.Map<Course>(request), token);

        return Ok();
    }
}