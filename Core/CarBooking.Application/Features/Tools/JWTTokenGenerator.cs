using CarBooking.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Tools
{
    public class JWTTokenGenerator
    {
        private readonly UserManager<AppUser> _userManager;
       

        public JWTTokenGenerator(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
           
        }

        public async Task<string> GenerateTokken(AppUser user)
        {

            var claims = new List<Claim>();
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                if (!string.IsNullOrEmpty(role))
                    claims.Add(new Claim(ClaimTypes.Role, role));
            }
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            if (!string.IsNullOrEmpty(user.UserName))
                claims.Add(new Claim("Username", user.UserName));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTTokenDefaults.Key));

            SigningCredentials credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddMinutes(JWTTokenDefaults.Expire);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer:JWTTokenDefaults.ValidIssuer,audience:JWTTokenDefaults.ValidAudience,notBefore:DateTime.UtcNow,signingCredentials:credentials, claims:claims,expires:expireDate);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(jwtSecurityToken);
        }
    }
}
