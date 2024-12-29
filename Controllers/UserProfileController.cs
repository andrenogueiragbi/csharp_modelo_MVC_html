using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class UserProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}