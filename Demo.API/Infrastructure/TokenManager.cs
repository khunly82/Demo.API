using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Demo.API.Infrastructure
{
    public class TokenManager(IConfiguration config, JwtSecurityTokenHandler tokenHandler)
    {
        public string CreateToken(int id, string username)
        {
            JwtSecurityToken token = new JwtSecurityToken(null, null, [
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, id.ToString()),
            ], DateTime.Now, DateTime.Now.AddDays(365), new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Signature"]??throw new Exception("Config is missing"))), SecurityAlgorithms.HmacSha256));
            return tokenHandler.WriteToken(token);
        }
    }
}
