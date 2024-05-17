
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


using SlutProjekt_ApiModels;
using SlutProjekt_Api.Interface;

namespace SlutProjekt_Api.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {

        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;

        public AuthenticationRepository(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }
        public string GenerateJwtToken(User user)
        {
            // Läser nyckeln från konfiguration och konverterar den till en byte-array
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            var securityKey = new SymmetricSecurityKey(key);

            // Skapar signeringsuppgifterna med angiven algoritm
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Skapar claims för den specifika användaren
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role)
        };

            // Skapar token med specifik utfärdare, publik och giltighetstid
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(120), // Använd UTC för att undvika tidszonproblem
                signingCredentials: credentials
            );

            // Returnerar den serialiserade token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidateLogin(string username, string password)
        {
            var user = _userRepository.FindByUsername(username);
            if (user != null && _userRepository.CheckPassword(user, password))
            {
                return true;
            }
            return false;
        }
    }
}
