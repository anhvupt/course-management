using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Extensions
{
    public class TokenHelper
    {
        public JwtConfigModel Config { get; set; }
        public TokenHelper(JwtConfigModel config)
        {
            Config = config;
        }
        public string GenerateToken(User user)
        {
            var key = Encoding.UTF8.GetBytes(Config.Key);
            var tokenHandler = new JwtSecurityTokenHandler();
            var claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, string.Concat(user.FirstMidName, user.LastName))
            });
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature
                );
            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Subject = claims,
                Issuer = Config.Issuer,
                Audience = Config.Audience,
                Expires = Config.Expires,
                SigningCredentials = credentials
            });
            return tokenHandler.WriteToken(token);
        }

    }
}
