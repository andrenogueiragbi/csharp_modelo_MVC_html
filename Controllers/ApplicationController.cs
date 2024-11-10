using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModeloPadrao.Models;

namespace ModeloPadrao.Controllers;

public class ApplicationController : Controller
{


    public IActionResult Email()
    {
        return View();
    }

    public IActionResult ChatBox()
    {
        return View();
    }

    public IActionResult FileManager()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult ToDoList()
    {
        return View();
    }
    public IActionResult Invoice()
    {
        return View();
    }
    public IActionResult Calendar()
    {
        return View();
    }




}
