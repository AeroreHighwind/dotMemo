using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models;
using dotMemo.Repositories;
using Microsoft.AspNetCore.Identity;

namespace dotMemo.Services
{
    public class AuthService(IUserRepository _userRepository, IPasswordHasher<User> _passHasher) : IAuthService
    {
        private readonly IUserRepository UserRepository = _userRepository;
        private readonly IPasswordHasher<User> PasswordHasher = _passHasher;

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
            try
            {
                var user = new User
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email,
                    Password = registerDto.Password
                };

                var hashedPassword = PasswordHasher.HashPassword(user, registerDto.Password);
                user.Password = hashedPassword;

                var createdUser = await UserRepository.CreateUser(user);
                var returnedUser = new User
                {
                    UserName = createdUser.UserName,
                    Email = createdUser.Email,
                };

                return returnedUser;
            }
            catch (Exception ex) {
                Console.WriteLine("An error ocurred while creating a new user: {0} ", ex);
                return null;
            }
        }

    }
}
