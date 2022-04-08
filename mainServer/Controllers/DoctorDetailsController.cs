using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{

    public class DoctorDetailsController: BaseController
    {
        public ActionResult Index(){
            
            return View("~/Views/doctor_details_page.cshtml");
        }
    }
}