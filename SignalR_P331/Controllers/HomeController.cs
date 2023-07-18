using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace SignalR_P331.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}

