using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UdemyCarBook.Application.Dtos;
using UdemyCarBook.Application.Features.Mediator.Results.AppUserResults;

namespace UdemyCarBook.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(GetCheckAppUserQueryResult result)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(result.Role))
                claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.Role, result.Role));
            
            if(!string.IsNullOrWhiteSpace(result.UserName))
                claims.Add(new Claim("Username",result.UserName));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: JwtTokenDefaults.ValidIssuer,
                audience: JwtTokenDefaults.ValidAudience,
                claims: claims,
                expires: expires,
                signingCredentials: signingCredentials,
                notBefore: DateTime.UtcNow
            );

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return new TokenResponseDto(tokenHandler.WriteToken(token), expires);
        }
    }
}
