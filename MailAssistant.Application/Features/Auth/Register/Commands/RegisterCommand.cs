using MailAssistant.Application.Features.Register.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MailAssistant.Application.Features.Register.Commands;

public class RegisterCommand : IRequest<RegisterUserResponseDto>
{
    public RegisterUserRequestDto RegisterDto { get; set; }

    public RegisterCommand(RegisterUserRequestDto dto)
    {
        RegisterDto = dto;
    }
}
