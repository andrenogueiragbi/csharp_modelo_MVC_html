using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class IconsController : Controller
{
    private readonly ILogger<IconsController> _logger;

    public IconsController(ILogger<IconsController> logger)
    {
        _logger = logger;
    }

    public IActionResult LineIcons()
    {
        return View();
    }

    public IActionResult Boxicons()
    {
        return View();
    }

    public IActionResult FeatherIcons()
    {
        return View();
    }

 
}
