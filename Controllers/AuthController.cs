using dotMemo.Interfaces;
using dotMemo.Models.User;
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
        public async Task<IActionResult> Login([FromBody] [NotNull] UserLoginModel loginRequest)
        {
            var loginResponse = await authService.Login(loginRequest);
            return loginResponse._Success ? Ok(loginResponse) : BadRequest(loginResponse);
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody][NotNull] UserRegisterModel registerDto)
        {
            var registerSuccessful = await authService.SignUp(registerDto);
            return registerSuccessful != null ? Created() : BadRequest();
        }

    }
}
