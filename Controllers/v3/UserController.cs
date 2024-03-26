using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Versioning.Api.Dto;

namespace Versioning.Api.Controllers.v3
{
    [ApiController]
    [Route("api/v{version:apiVersion}/User")]
    [ApiVersion("3.0")]
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
                Version = "3.0"
            });
        }
    }
}
