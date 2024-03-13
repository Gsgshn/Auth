using Auth.Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Services
{
    public class UserService
    {
        
        private readonly UserManager<IdentityUser<Guid>> _userManager;
        private readonly IJwtProvider _jwtProvider;

        public UserService( IJwtProvider jwtProvider)
        {
            
            _jwtProvider = jwtProvider;
        }
        public async Task Register(string userName, string email, string password)
        {
           

            var user = new IdentityUser<Guid>
            {
                UserName = userName,
                Email = email
            };
            await _userManager.CreateAsync(user, password);
        }

        public async Task<string> Login(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            var result = await _userManager.CheckPasswordAsync(user, password);

            if (result == false)
            {
                throw new Exception("Failed to login");
            }

            var token = _jwtProvider.GenerateToken(user);

            return token;
        }
    }
}
