using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class PricingTableController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}