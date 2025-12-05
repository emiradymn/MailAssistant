using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MailAssistant.Application.Features.Users.Commands;

public class RegisterCommand : IRequest<RegisterResponse>
{
    public string FullName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;
    public string ConfirmPassword { get; set; } = null!;
}
