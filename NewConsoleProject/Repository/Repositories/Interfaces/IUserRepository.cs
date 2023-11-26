using Domain.Models;

namespace Repository.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(string email, string password);
        void AddUser(User user);
    }
}
