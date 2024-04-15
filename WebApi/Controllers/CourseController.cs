using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController(IBaseService<Course> courseService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id, CancellationToken token)
    {
        var response = await courseService.GetAsync(id, token);

        return Ok(mapper.Map<GetCourseResponse>(response));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await courseService.GetAllAsync(token);

        return Ok(mapper.Map<IEnumerable<GetAllCourseResponse>>(response));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCourseRequest request, CancellationToken token)
    {
        await courseService.CreateAsync(mapper.Map<Course>(request), token);

        return Ok();
    }
}