using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class TableController : Controller
{
    private readonly ILogger<TableController> _logger;

    public TableController(ILogger<TableController> logger)
    {
        _logger = logger;
    }

    public IActionResult BasicYable()
    {
        return View();
    }

    public IActionResult Datatable()
    {
        return View();
    }


}
