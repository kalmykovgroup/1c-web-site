using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    
    public IActionResult Get()
    {
        return Ok("Login endpoint");
    }
}