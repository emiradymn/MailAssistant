using MailAssistant.Application.Features.Auth.Login.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.Auth.Login.Commands;

public class LoginCommand : IRequest<LoginUserResponseDto>
{
    public LoginUserRequestDto LoginDto { get; set; }

    public LoginCommand(LoginUserRequestDto dto)
    {
        LoginDto = dto;
    }
}
