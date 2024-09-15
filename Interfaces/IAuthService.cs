
using dotMemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotMemo.Interfaces
{
    public interface IAuthService
    {
        public Task<IActionResult> Login(LoginModel loginDto);

        public Task<IActionResult> SignUp(RegisterModel registerDto);

        public Task<IActionResult> Logout(int userId);

        public Task<IActionResult> ChangePassword(string username, string password);
    }
}
