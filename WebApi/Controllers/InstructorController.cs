using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InstructorController(IBaseService<Instructor> instructorService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id, CancellationToken token)
    {
        var response = await instructorService.GetAsync(id, token);

        return Ok(mapper.Map<GetInstructorResponse>(response));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await instructorService.GetAllAsync(token);

        return Ok(mapper.Map<IEnumerable<GetInstructorResponse>>(response));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateInstructorRequest request, CancellationToken token)
    {
        await instructorService.CreateAsync(mapper.Map<Instructor>(request), token);

        return Ok();
    }
}