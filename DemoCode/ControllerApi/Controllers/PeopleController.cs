using Microsoft.AspNetCore.Mvc;
using People.Library;

namespace ControllerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    // For API Controllers
    // "FromServices" is optional for method injection

    [HttpGet(Name = "GetPeople")]
    public async Task<IEnumerable<Person>> Get(
        [FromServices] IPeopleProvider provider)
    {
        return await provider.GetPeople();
    }
}
