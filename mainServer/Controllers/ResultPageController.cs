using System;
using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class Result_Model{
        public string disease {get; set;}
        public string accuracy {get; set;}
        public string email {get; set;}
    }

    public class ResultPageController : BaseController
    {
        public IActionResult Index(string disease, string accuracy){
            
            String s_email = GetUserEMAIL();



            Result_Model rm = new Result_Model();
            rm.accuracy = accuracy;
            rm.disease = disease;
            rm.email = s_email;
            return View("~/Views/result_page.cshtml", rm);
        }
    }



}