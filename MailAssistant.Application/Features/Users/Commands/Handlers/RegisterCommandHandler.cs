using MailAssistant.Application.Interfaces.Services;
using MailAssistant.Domain.Entities;
using MediatR;

namespace MailAssistant.Application.Features.Users.Commands.Handlers;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
{
    private readonly IUserService _userService;

    public RegisterCommandHandler(IUserService userService)
    {
        _userService = userService;
    }


    public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        if (request.Password != request.ConfirmPassword)
        {
            return new RegisterResponse
            {
                Succeeded = false,
                Message = "Şifreler uyuşmuyor"
            };
        }
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            FullName = request.FullName,
            UserName = request.UserName,
            Email = request.Email,
            Phone = request.Phone,
            DefaultSignature = ""
        };

        var result = await _userService.RegisterAsync(user, request.Password);

        return new RegisterResponse
        {
            Succeeded = result.Succeded,
            Message = result.Message
        };
    }

}
