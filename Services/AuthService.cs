using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models;
using dotMemo.Repositories;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace dotMemo.Services
{
    public class AuthService(IUserRepository _userRepository, IPasswordHasher<User> _passHasher) : IAuthService
    {
        private readonly IUserRepository UserRepository = _userRepository;
        private readonly IPasswordHasher<User> PasswordHasher = _passHasher;

        public async Task<User> ChangePassword(string Username, string password)
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

        public async Task<UserModel> SignUp(RegisterModel registerDto)
        {
            try
            {
                var user = new User
                {
                    Username = registerDto.Username,
                    Email = registerDto.Email,
                    Password = registerDto.Password
                };

                var hashedPassword = PasswordHasher.HashPassword(user, registerDto.Password);
                user.Password = hashedPassword;

                var createdUser = await UserRepository.CreateUser(user);

                var returnedUser = createdUser.Adapt<UserModel>();

                return returnedUser;
            }
            catch (Exception ex) {
                Console.WriteLine("An error ocurred while creating a new user");
                return null;
            }
        }

    }
}
