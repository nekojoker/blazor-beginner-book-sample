using Microsoft.AspNetCore.Mvc;

namespace BlazorWebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public void Get() => throw new NotImplementedException();
}
