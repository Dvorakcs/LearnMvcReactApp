using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LearnMvcReactApp.Server.Services
{
    public class TokenService : ITokenService
    {
        private readonly byte[] _JWToken;
        public TokenService(IConfiguration configuration)
        {
            _JWToken = Encoding.ASCII.GetBytes(configuration.GetSection("JWTConfiguracao")["secrets"]);
        }
        public async Task<string> GetTokenAsync(Usuarios Usuario)
        {

            var TokenConfig = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim("UsuarioId", Usuario.Id.ToString()),

                }),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(_JWToken), SecurityAlgorithms.HmacSha256Signature),
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(TokenConfig);
            var tokenWrite = tokenHandler.WriteToken(token);

            return tokenWrite.ToString();

        }
    }
}
