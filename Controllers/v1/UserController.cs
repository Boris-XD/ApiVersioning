using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Versioning.Api.Dto;

namespace Versioning.Api.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/User")]
    [ApiVersion("1.0")]
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
                Version = "1.0"
            });
        }
    }
}
