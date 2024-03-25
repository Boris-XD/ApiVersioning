using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Versioning.Api.Dto;

namespace Versioning.Api.Controllers.v2
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("2.0")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetUserOne()
        {
            return Ok(new UserResponse()
            {
                Id = Guid.NewGuid(),
                LastName = "Doe",
                FirstName = "John",
                Version = "2.0"
            });
        }
    }
}