using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamAPP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}