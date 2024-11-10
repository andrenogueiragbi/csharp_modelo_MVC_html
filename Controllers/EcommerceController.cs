using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class EcommerceController : Controller
{
    private readonly ILogger<EcommerceController> _logger;

    public EcommerceController(ILogger<EcommerceController> logger)
    {
        _logger = logger;
    }

    public IActionResult Products()
    {
        return View();
    }
    public IActionResult ProductsDetails()
    {
        return View();
    }
    public IActionResult ProductsAddNewProducts()
    {
        return View();
    }
    public IActionResult Orders()
    {
        return View();
    }

 
}
