using Microsoft.AspNetCore.Mvc;
using SampleApiVersioning.Models;

namespace SampleApiVersioning.Controllers.V2
{

    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult AllUsers()
        {
            List<UserV2> users = new List<UserV2>() {

            new UserV2() { Id = Guid.NewGuid(),Name = "AbDulrhman Elshamy"},
            new UserV2() { Id = Guid.NewGuid(),Name = "Mohamed Abdelhamied"},
            new UserV2() { Id = Guid.NewGuid(),Name = "Ashraf Gad"},
            };

            return Ok(users);
        }
    }
}
