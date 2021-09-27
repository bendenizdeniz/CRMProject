using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.Controllers
{
    public class AppointmentController : Controller
    {
        [HttpGet]
        public IActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appointment(Appointment appointment)
        {
            return View();
        }
    }
}
