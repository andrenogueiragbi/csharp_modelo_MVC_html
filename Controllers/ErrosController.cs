using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class ErrosController : Controller
{
    // GET
    public IActionResult Errors404Error()
    {
        return View();
    }

    public IActionResult Errors500Error()
    {
        return View();
    }
    public IActionResult ErrorsComingSoon()
    {
        return View();
    }    
    public IActionResult ErrorBlankPage()
    {
        return View();
    }
}