using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class ChartsController : Controller
{
    // GET
    public IActionResult ChartsApexChart()
    {
        return View();
    }    
    public IActionResult ChartsChartjs()
    {
        return View();
    }    
    public IActionResult ChartsHighcharts()
    {
        return View();
    }
}