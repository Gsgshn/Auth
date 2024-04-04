using Auth.Application.Services;
using Auth.Contracts.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public static async Task<IResult> Register(RegisterUserRequest request, UserService userService)
        {
            await userService.Register(request.UserName, request.Email, request.Password);
            return Results.Ok();
        }
        [HttpPost]
        public static async Task<IResult> Login(LoginUserRequest request, UserService userService)
        {

            var token = await userService.Login(request.Email, request.Password);
            return Results.Ok(token);
        }
    }
}
