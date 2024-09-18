
using dotMemo.Entities;
using dotMemo.Models.Responses;
using dotMemo.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace dotMemo.Interfaces
{
    public interface IAuthService
    {
        public Task<LoginResponseModel> Login(UserLoginModel loginDto);

        public Task<UserModel> SignUp(UserRegisterModel registerDto);

        public Task<bool> Logout(int userId);

        public Task<User> ChangePassword(string Username, string password);
    }
}
