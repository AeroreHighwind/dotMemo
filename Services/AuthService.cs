using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models;
using dotMemo.Repositories;

namespace dotMemo.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository UserRepository;
        public AuthService(IUserRepository userRepository) {
        UserRepository = userRepository;
        }

        public async Task<User> ChangePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Login(LoginModel loginDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> SignUp(RegisterModel registerDto)
        {
            var user = new User
            {
                UserName = registerDto.Username,
                Email = registerDto.Email,
                Password = registerDto.Password
            };

           var createdUser = await UserRepository.CreateUser(user);
            var returnedUser = new User
             {
                UserName = registerDto.Username,
                Email = registerDto.Email,
            };

            return createdUser;
        }

    }
}
