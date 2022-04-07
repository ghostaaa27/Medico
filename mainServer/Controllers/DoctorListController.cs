using Microsoft.AspNetCore.Mvc;
using Server2;

namespace mainServer.Controllers{
    
    public class DoctorListController : BaseController
    {
        
        public IActionResult Index(){
            
            return View("~/Views/doctor_list_page.cshtml");
        }
    }
}