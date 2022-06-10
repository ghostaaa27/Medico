using System;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class Result_Model{
        public string disease {get; set;}
        public string accuracy {get; set;}
    }

    public class ResultPageController : BaseController
    {
        public IActionResult Index(string disease, string accuracy){
            // Console.WriteLine(disease + accuracy);

            Result_Model rm = new Result_Model();
            rm.accuracy = accuracy;
            rm.disease = disease;
            return View("~/Views/result_page.cshtml", rm);
        }
    }



}