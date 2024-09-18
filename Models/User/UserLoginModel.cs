using System.ComponentModel.DataAnnotations;

namespace dotMemo.Models.User
{
    public class UserLoginModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
