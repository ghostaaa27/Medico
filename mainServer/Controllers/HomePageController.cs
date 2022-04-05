using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class HomePageController : BaseController
    {
        public IActionResult Index()
        {
            return View("~/Views/home_page.cshtml");
        }
    }
}