using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdresDefteri.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}