using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotMemo.Services
{
    public class AuthService : IAuthService
    {
        public AuthService() { }

        public Task<IActionResult> ChangePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Login(LoginModel loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> SignUp(RegisterModel registerDto)
        {
            throw new NotImplementedException();
        }
    }
}
