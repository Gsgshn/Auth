using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Interfaces
{
    public interface IJwtProvider
    {
        public string GenerateToken(IdentityUser<Guid> user);
    }
}
