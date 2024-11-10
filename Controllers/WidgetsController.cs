using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class WidgetsController : Controller
{
    private readonly ILogger<WidgetsController> _logger;

    public WidgetsController(ILogger<WidgetsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

 
}
