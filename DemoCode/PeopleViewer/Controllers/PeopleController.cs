using Microsoft.AspNetCore.Mvc;
using People.Library;

namespace PeopleViewer.Controllers;

public class PeopleController : Controller
{
    // For MVC Controllers
    // "FromServices" is required for method injection

    public async Task<IActionResult> GetPeople(
        [FromServices] IPeopleProvider provider)
    {
        ViewData["Title"] = "Method Injection";
        ViewData["ReaderType"] = provider.GetType().ToString();

        var people = await provider.GetPeople();
        return View("Index", people);
    }
}
