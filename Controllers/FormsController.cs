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

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult FormElements()
    {
        return View();
    }
    public IActionResult InputGroups()
    {
        return View();
    }
    public IActionResult FormsLayouts()
    {
        return View();
    }
    public IActionResult FormValidation()
    {
        return View();
    }
    public IActionResult FormWizard()
    {
        return View();
    }
    public IActionResult TextEditor()
    {
        return View();
    }
    public IActionResult FileUpload()
    {
        return View();
    }
    public IActionResult DatePickers()
    {
        return View();
    }
    public IActionResult Select2()
    {
        return View();
    }



 
}
