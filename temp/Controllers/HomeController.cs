using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index(){
            
            return View("~/Views/landing_page.cshtml");
        }
    }
}