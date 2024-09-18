using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models.Responses;
using dotMemo.Models.User;
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

        public async Task<LoginResponseModel> Login(UserLoginModel loginDto)
        {
            try
            {
                var existingUser = await UserRepository.GetUserByEmail(loginDto.Email);
                Console.WriteLine("EXISTING USER {0}", existingUser);
                var authResult = PasswordHasher.VerifyHashedPassword(existingUser, existingUser.Password, loginDto.Password);
                if (authResult != PasswordVerificationResult.Success) throw new Exception("Login failed");
                {
                    var responseDto = new LoginResponseModel
                    {
                        _AccessToken = "SUCCESS",
                        _RefreshToken = "loginDto"
                    };

                    return responseDto;
                }
            }
            catch (Exception ex) {
                return new LoginResponseModel
                {
                    _AccessToken = "FAILED",
                    _RefreshToken = "FAILED",
                };
            }
            
        }

        public async Task<bool> Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> SignUp(UserRegisterModel registerDto)
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
