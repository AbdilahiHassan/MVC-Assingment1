
using Microsoft.AspNetCore.Mvc;
using MVC_Assingment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MVC_Assingment1.Doctorcontroler
{
    public class DoctorController : Controller
    {
       

        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(double temp)
        {
            ViewBag.Diagnos = DrCheck.Doctor(temp);


            return View();
        }




    }
}

