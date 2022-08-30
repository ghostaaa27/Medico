using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server;
using Server2;

namespace mainServer.Controllers{



    public class DoctorDetails{
        public string email{get;set;}
        public string name{get;set;}
        public string institute{get;set;}
        public string address{get;set;}
    }
    public class DoctorDetailsController: BaseController
    {
        // public ActionResult Index(){
        //     string s_email = GetUserEMAIL();


        //     SessionCheckerModel sessionCheckerModel = new SessionCheckerModel();
        //     sessionCheckerModel.email = s_email;

        
        //     return View("~/Views/doctor_details_page.cshtml", sessionCheckerModel);
        // }

        public async Task<ActionResult<List<DoctorDetails>>> Index(int id, string name, string institute, string address){
          
            String s_email = GetUserEMAIL();

            DoctorDetails dd = new DoctorDetails();
            dd.name = name;
            dd.institute = institute;
            dd.address = address;
            dd.email = s_email;

            return View("~/Views/doctor_details_page.cshtml", dd);
        }
    }
}