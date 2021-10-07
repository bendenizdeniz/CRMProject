using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.ViewComponents
{
    public class AppointmentListByUserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Appointment> model)
        {
            return View(model: model);
        }
    }
}
