using Microsoft.AspNetCore.Mvc;
using SampleApiVersioning.Models;

namespace SampleApiVersioning.Controllers.V1
{

    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0",Deprecated = true)]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult AllUsers()
        {
            List<UserV1> users = new List<UserV1>() {

            new UserV1() { Id = 1,Name = "AbDulrhman Elshamy"},
            new UserV1() { Id = 2,Name = "Mohamed Abdelhamied"},
            new UserV1() { Id = 3,Name = "Ashraf Gad"},
            };

            return Ok(users);
        }
    }
}
