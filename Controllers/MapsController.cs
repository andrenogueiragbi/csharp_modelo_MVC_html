using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class MapsController : Controller
{
    // GET
    public IActionResult MapGoogleMaps()
    {
        return View();
    }    
    public IActionResult MapVectorMaps()
    {
        return View();
    }
}