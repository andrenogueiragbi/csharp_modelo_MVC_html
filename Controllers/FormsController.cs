using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class FormsController : Controller
{
    private readonly ILogger<FormsController> _logger;

    public FormsController(ILogger<FormsController> logger)
    {
        _logger = logger;
    }

    public IActionResult index()
    {
        return View();
    }



 
}
