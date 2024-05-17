using SlutProjekt_ApiModels;

namespace SlutProjekt_Api.Interface
{
    public interface IUserRepository
    {
       
            Task<int> CreateUser(User user);
            bool CheckPassword(User user, string password);
            User FindByUsername(string username);
        
    }
}
