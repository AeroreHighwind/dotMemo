using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Models;
using dotMemo.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace dotMemo.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        AuthController( AuthService _auth) { 
            this.authService = _auth;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] [NotNull] LoginModel loginRequest)
        {
            return await authService.Login(loginRequest);
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody][NotNull] RegisterModel registerDto)
        {
            return await authService.SignUp(registerDto);
        }

    }
}
