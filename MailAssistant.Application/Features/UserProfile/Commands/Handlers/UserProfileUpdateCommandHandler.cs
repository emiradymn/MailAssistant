using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Features.UserProfile.Commands;
using MailAssistant.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

public class UserProfileUpdateCommandHandler
    : IRequestHandler<UserProfileUpdateCommand, Unit>
{
    private readonly IUserRepository _userRepository;
    private readonly UserManager<AppUser> _userManager;

    public UserProfileUpdateCommandHandler(
        IUserRepository userRepository,
        UserManager<AppUser> userManager)
    {
        _userRepository = userRepository;
        _userManager = userManager;
    }

    public async Task<Unit> Handle(
        UserProfileUpdateCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _userRepository
            .GetUserProfileAsync(request.UserId, cancellationToken);

        if (user is null)
            throw new Exception("Kullanıcı bulunamadı");

        // 🔹 Identity dışı alanlar
        user.FullName = request.FullName;
        user.CurrentPosition = request.CurrentPosition;
        user.DefaultSignature = request.DefaultSignature;

        // 🔹 Identity alanı (UserName)
        if (user.UserName != request.UserName)
        {
            var result = await _userManager.SetUserNameAsync(
                user,
                request.UserName
            );

            if (!result.Succeeded)
                throw new Exception(
                    string.Join(
                        ", ",
                        result.Errors.Select(e => e.Description)
                    )
                );
        }

        if (user.PhoneNumber != request.PhoneNumber)
        {
            var result = await _userManager.SetPhoneNumberAsync(
                user,
                request.PhoneNumber
            );

            if (!result.Succeeded)
                throw new Exception(
                    string.Join(", ", result.Errors.Select(e => e.Description))
                );
        }


        await _userRepository.UpdateAsync(user);

        return Unit.Value;
    }
}
