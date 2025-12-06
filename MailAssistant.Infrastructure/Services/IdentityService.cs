using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using MailAssistant.Application.Interfaces.Services;
using MailAssistant.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MailAssistant.Infrastructure.Services;

public class IdentityService : IUserService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IConfiguration _config;

    public IdentityService(UserManager<AppUser> userManager, IConfiguration config)
    {
        _userManager = userManager;
        _config = config;

    }

    private string GenerateJwtToken(AppUser user)
    {
        var claims = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),  // Guid → string
        new Claim(JwtRegisteredClaimNames.Email, user.Email ?? ""),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim("username", user.UserName)
    };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public async Task<(bool Success, string Message, string Token, Guid? UserId)> LoginAsync(string userNameOrEmail, string password)
    {
        var user = await _userManager.FindByEmailAsync(userNameOrEmail)
                   ?? await _userManager.FindByNameAsync(userNameOrEmail);

        if (user == null)
            return (false, "Kullanıcı bulunamadı", null, null);

        var check = await _userManager.CheckPasswordAsync(user, password);

        if (!check)
            return (false, "Email veya şifre hatalı", null, null);

        var token = GenerateJwtToken(user);

        return (true, "Giriş başarılı", token, user.Id);
    }

    public async Task<(bool Succeded, string Message)> RegisterAsync(AppUser user, string password)
    {
        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            var error = string.Join(" |", result.Errors.Select(x => x.Description));
            return (false, error);
        }

        return (true, "Kullanıcı başarıyla oluşturuldu");
    }

}
