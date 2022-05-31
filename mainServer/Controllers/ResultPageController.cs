using System;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class ResultPageController : BaseController
    {
        public IActionResult Index(string disease){
            Console.WriteLine(disease);
            return View("~/Views/result_page.cshtml");
        }
    }



}