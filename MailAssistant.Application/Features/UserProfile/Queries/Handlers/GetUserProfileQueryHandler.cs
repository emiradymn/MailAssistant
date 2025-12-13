using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Features.UserProfile.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.UserProfile.Queries.Handlers;

public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, ListUserProfileDto>
{
    private readonly IUserRepository _userRepository;

    public GetUserProfileQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


    public async Task<ListUserProfileDto> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserProfileAsync(request.UserId);

        if (user is null)
            throw new Exception("Kullanıcı bulunamadı");

        return new ListUserProfileDto
        {
            UserId = user.Id,
            FullName = user.FullName,
            Phone = user.PhoneNumber, // Identity'nin kendi PhoneNumber alanı
            Address = user.Address,
            CurrentPosition = user.CurrentPosition,
            DefaultSignature = user.DefaultSignature
        };
    }


}
