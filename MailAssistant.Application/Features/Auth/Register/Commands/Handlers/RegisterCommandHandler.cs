using MailAssistant.Application.Features.Register.Dtos;
using MailAssistant.Application.Interfaces.Services;
using MailAssistant.Domain.Entities;
using MediatR;

namespace MailAssistant.Application.Features.Register.Commands.Handlers;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterUserResponseDto>
{
    private readonly IUserService _userService;

    public RegisterCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<RegisterUserResponseDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var dto = request.RegisterDto;

        var response = new RegisterUserResponseDto();

        if (dto.Password != dto.ConfirmPassword)
        {
            response.Success = false;
            response.Errors.Add("Şifreler eşleşmiyor!");
            return response;
        }

        var user = new AppUser
        {
            FullName = dto.FullName,
            UserName = dto.UserName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber
        };

        var result = await _userService.RegisterAsync(user, dto.Password);

        if (!result.Succeded)
        {
            response.Success = false;
            response.Errors.Add(result.Message);
            return response;
        }

        response.Success = true;
        response.UserId = user.Id;
        response.Message = "Kullanıcı başarıyla oluşturuldu";

        return response;
    }

}
