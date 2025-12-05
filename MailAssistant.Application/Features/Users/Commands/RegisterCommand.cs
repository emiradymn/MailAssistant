using MailAssistant.Application.Features.Users.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MailAssistant.Application.Features.Users.Commands;

public class RegisterCommand : IRequest<RegisterUserResponseDto>
{
    public RegisterUserRequestDto RegisterDto { get; set; }

    public RegisterCommand(RegisterUserRequestDto dto)
    {
        RegisterDto = dto;
    }
}
