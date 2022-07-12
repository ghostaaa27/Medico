using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{
    
    public class DoctorListController : BaseController
    {
        
        public IActionResult Index(){
            
            
            string s_email = GetUserEMAIL();


            SessionCheckerModel sessionCheckerModel = new SessionCheckerModel();
            sessionCheckerModel.email = s_email;

        
            return View("~/Views/doctor_list_page.cshtml", sessionCheckerModel);
        }
    }
}