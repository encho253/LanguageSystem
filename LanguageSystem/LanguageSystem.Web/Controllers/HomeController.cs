using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanguageSystem.Web.Models;

namespace LanguageSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}