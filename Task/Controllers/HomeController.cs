using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//using Task.Models;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
