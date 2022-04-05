using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class ResultPageController : BaseController
    {
        public IActionResult Index(){
            return View("~/Views/result_page.cshtml");
        }
    }



}