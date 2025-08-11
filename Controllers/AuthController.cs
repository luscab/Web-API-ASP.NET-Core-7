using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if(username == "lucas" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Domain.Model.EmployeeAggregate.Employee());
                return Ok(token);
            }
            
            return Unauthorized();
        }
    }
}
