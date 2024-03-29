﻿using System.ComponentModel.DataAnnotations;

namespace Auth.Contracts.Users
{
    public class LoginUserRequest
    {
        [Required] public string Email { get; set; }
        [Required] public string Password { get; set; }
    }
}
