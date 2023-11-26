using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Services.Services
{
    public class UserRegistration
    {
        private readonly IUserRepository _userRepository;

        public UserRegistration()
        {
        }

        public UserRegistration(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(User user)
        {
            _userRepository.AddUser(user);
        }
    }
}