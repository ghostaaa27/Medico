using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class HomePageController : BaseController
    {
        public IActionResult Index()        
        {
            string s_email = GetUserEMAIL();


            SessionCheckerModel sessionCheckerModel = new SessionCheckerModel();
            sessionCheckerModel.email = s_email;

        
            return View("~/Views/home_page.cshtml", sessionCheckerModel);
            
        }
    }
}