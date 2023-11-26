using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
