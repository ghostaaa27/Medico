using System.Collections.Generic;
using System.Threading.Tasks;
using MediShare.Controllers;
using Microsoft.AspNetCore.Mvc;
using Server;
using Server2;

namespace mainServer.Controllers{



    public class DoctorList{
        public int id{get;set;}
        public string name{get;set;}
        public string institute{get;set;}
        public string address{get;set;}
        public string speciality{get; set;}
    }
    
    public class DoctorListController : BaseController
    {
        
        public IActionResult Index(){
            
            
            string s_email = GetUserEMAIL();


            SessionCheckerModel sessionCheckerModel = new SessionCheckerModel();
            sessionCheckerModel.email = s_email;

        
            return View("~/Views/doctor_list_page.cshtml", sessionCheckerModel);
        }

        public async Task<ActionResult<List<DoctorList>>> Dlist(){
            var res = await DAL.ExecuteReaderAsync<DoctorList>(
                    @"SELECT * FROM doctordetails",
                    new string[,]{
                    }
                );

            return res;
        }
    }
}