using System.Security.Claims;
using MailAssistant.Application.Common.Interfaces.Models;
using MailAssistant.Application.Features.UserProfile.Commands;
using MailAssistant.Application.Features.UserProfile.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MailAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserProfileController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> GetProfile()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var result = await _mediator.Send(
            new GetUserProfileQuery(Guid.Parse(userId))
        );

        return Ok(result);
    }

    [Authorize]
    [HttpPut("update")]
    public async Task<IActionResult> UpdateProfile([FromBody] UpdateUserProfileRequest request)
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userIdClaim))
        {
            return Unauthorized(ResponseDto<string>.Fail("Kullanıcı doğrulanamadı"));
        }
        ;

        var command = new UserProfileUpdateCommand
        {
            UserId = Guid.Parse(userIdClaim),
            FullName = request.FullName,
            UserName = request.UserName,
            PhoneNumber = request.PhoneNumber,
            CurrentPosition = request.CurrentPosition,
            DefaultSignature = request.DefaultSignature
        };

        await _mediator.Send(command);

        return Ok(ResponseDto<string>.SuccessResult("Profil başarıyla güncellendi"));
    }
}
