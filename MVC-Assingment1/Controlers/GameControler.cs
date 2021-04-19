using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Assingment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assingment1.Controlers
{
    public class GameControler : Controller
    {
        [HttpGet]
        public IActionResult GuessingGame()
        {
            return View();
        }
    }
}

    

