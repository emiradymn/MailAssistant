using System.Runtime.CompilerServices;
using MailAssistant.Application.Common.Interfaces.Services;
using MailAssistant.Application.Features.Auth.Login.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.Auth.Login.Commands.Handlers;

public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginUserResponseDto>
{
    private readonly IUserService _userService;

    public LoginCommandHandler(IUserService userService)
    {
        _userService = userService;
    }


    public async Task<LoginUserResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var response = new LoginUserResponseDto();
        var dto = request.LoginDto;

        var result = await _userService.LoginAsync(dto.UserNameOrEmail, dto.Password);

        if (!result.Success)
        {
            response.Success = false;
            response.Errors.Add(result.Message);
            return response;
        }

        response.Success = true;
        response.Token = result.Token;
        response.UserId = response.UserId;
        response.Message = "Giriş yapıldı";

        return response;
    }

}
