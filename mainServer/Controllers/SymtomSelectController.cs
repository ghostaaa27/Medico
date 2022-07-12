using System;
using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers
{
    public class SymtomSelectController : BaseController
    {
        public IActionResult Index()
        {
            String s_email = GetUserEMAIL();


            SessionCheckerModel sessionCheckerModel = new SessionCheckerModel();
            sessionCheckerModel.email = s_email;

        
            return View("~/Views/symtom_select_page.cshtml", sessionCheckerModel);
        }
    }
}