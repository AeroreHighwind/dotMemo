using dotMemo.Interfaces;
using dotMemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace dotMemo.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController(IAuthService _auth) : ControllerBase
    {
        private readonly IAuthService authService = _auth;

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] [NotNull] LoginModel loginRequest)
        {
            var loginSuccessful = await authService.Login(loginRequest);
            return loginSuccessful != null ? Ok(loginSuccessful) : BadRequest(loginSuccessful);
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody][NotNull] RegisterModel registerDto)
        {
            var registerSuccessful = await authService.SignUp(registerDto);
            return registerSuccessful != null ? Ok(registerSuccessful) : BadRequest(registerSuccessful);
        }

    }
}
