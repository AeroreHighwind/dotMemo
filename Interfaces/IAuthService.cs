
using dotMemo.Entities;
using dotMemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotMemo.Interfaces
{
    public interface IAuthService
    {
        public Task<User> Login(LoginModel loginDto);

        public Task<User> SignUp(RegisterModel registerDto);

        public Task<bool> Logout(int userId);

        public Task<User> ChangePassword(string username, string password);
    }
}
