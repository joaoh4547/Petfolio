using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPet), StatusCodes.Status201Created)]
    public IActionResult Register(RequestRegisterPet request)
    {
        return Created();
    }

}
