using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class DoctorDetailsController: BaseController
    {
        public ActionResult Index(){
            string s_email = GetUserEMAIL();


            SessionCheckerModel sessionCheckerModel = new SessionCheckerModel();
            sessionCheckerModel.email = s_email;

        
            return View("~/Views/doctor_details_page.cshtml", sessionCheckerModel);
        }
    }
}