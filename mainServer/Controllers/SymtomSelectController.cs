using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers
{
    public class SymtomSelectController : BaseController
    {
        public IActionResult Index()
        {
            return View("~/Views/");
        }
    }
}