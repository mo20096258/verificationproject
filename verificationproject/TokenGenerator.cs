using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificationproject
{
    public class TokenGenerator
    {
        public string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MynameisJamesBond007")); //You can put any key you like, for reference purposes we have put in this key
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer:"", //the website that would be accessing the api
                audience:"", //the website that would be accessing the api
                expires: DateTime.Now.AddHours(3),  //Add time accordingly, Default 3 hours
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
