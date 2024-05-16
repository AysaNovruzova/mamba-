using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

namespace Mamba.UI.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

     
    }
}
