using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class ContentController : Controller
{
    private readonly ILogger<ContentController> _logger;

    public ContentController(ILogger<ContentController> logger)
    {
        _logger = logger;
    }

    public IActionResult GridSystem()
    {
        return View();
    }

    public IActionResult Typography()
    {
        return View();
    }

    public IActionResult TextUtilities()
    {
        return View();
    }

 
}
