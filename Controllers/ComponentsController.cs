using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class ComponentsController : Controller
{
    private readonly ILogger<ComponentsController> _logger;

    public ComponentsController(ILogger<ComponentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Alerts()
    {
        return View();
    }

    public IActionResult Accordions()
    {
        return View();
    }
 
    public IActionResult Badges()
    {
        return View();
    }
    public IActionResult Buttons()
    {
        return View();
    }
    public IActionResult Cards()
    {
        return View();
    }
    public IActionResult Carousels()
    {
        return View();
    }
    public IActionResult ListGroups()
    {
        return View();
    }
    public IActionResult MediaObjects()
    {
        return View();
    }
    public IActionResult Modals()
    {
        return View();
    }
    public IActionResult NavsTabs()
    {
        return View();
    }
    public IActionResult Navbar()
    {
        return View();
    }
    public IActionResult Pagination()
    {
        return View();
    }
    public IActionResult PopoversTooltips()
    {
        return View();
    }
    public IActionResult Progress()
    {
        return View();
    }
    
    public IActionResult Spinners()
    {
        return View();
    }
    public IActionResult Notifications()
    {
        return View();
    }
    public IActionResult AvatrsChips()
    {
        return View();
    }
    
}
