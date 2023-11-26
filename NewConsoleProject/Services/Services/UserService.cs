using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Services.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(User user)
        {
            _userRepository.Register(user);
        }

        public User Login(string email, string password)
        {
            return _userRepository.Login(email, password);
        }
    }
}
