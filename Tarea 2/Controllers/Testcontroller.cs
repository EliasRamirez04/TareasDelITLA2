using Microsoft.AspNetCore.Mvc;

namespace Tarea2.CrudApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { mensaje = "Swagger está funcionando correctamente" });
}