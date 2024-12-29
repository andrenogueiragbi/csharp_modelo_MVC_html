using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class FaqController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}