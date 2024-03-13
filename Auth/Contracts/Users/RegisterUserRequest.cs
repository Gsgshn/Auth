﻿using System.ComponentModel.DataAnnotations;

namespace Auth.Contracts.Users
{
    public class RegisterUserRequest
    {
        [Required] public string UserName { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Password { get; set; }

    }
}
