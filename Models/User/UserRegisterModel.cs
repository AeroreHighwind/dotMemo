﻿using System.ComponentModel.DataAnnotations;

namespace dotMemo.Models.User
{
    public class UserRegisterModel
    {
        [Required]
        [MaxLength(12)]
        [MinLength(4)]
        public string Username { get; set; }
        [Required]
        [MaxLength(16)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
