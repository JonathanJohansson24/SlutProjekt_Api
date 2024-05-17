

using SlutProjekt_ApiModels;

namespace SlutProjekt_Api.Interface
{
    public interface IAuthenticationRepository
    {
        public string GenerateJwtToken(User user);
        public bool ValidateLogin(string username, string password);
    }
}
