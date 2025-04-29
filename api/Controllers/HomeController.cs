using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;
 
[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}