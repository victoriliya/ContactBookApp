using ContactBookApplication.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactBookApplication.Utilities
{
    public static class AppUtilities
    {


        public static bool IsValidEmail(this string email)
                {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        public static object GenerateToken(string username,string email, string userId, IConfiguration configuration, string[] roles)
        {
            // create ans set up claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.NameIdentifier, userId)
            };

            //create and setup roles
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            // create security token descriptor
            var securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials( new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JWT:JWTSigninKey").Value)) , SecurityAlgorithms.HmacSha256Signature)
            };

            // create a token handler
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenCreated = tokenHandler.CreateToken(securityTokenDescriptor);

            return new {
                token = tokenHandler.WriteToken(tokenCreated),
                id = userId
            };
        }

    }
}
