using MailAssistant.Application.Features.Users.Commands;
using MailAssistant.Application.Features.Users.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MailAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto dto)
    {
        var command = new RegisterCommand(dto);
        var result = await _mediator.Send(command);

        if (!result.Success)
            return BadRequest(result);

        return Ok(result);
    }
}
