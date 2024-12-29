using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class TimelineController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}