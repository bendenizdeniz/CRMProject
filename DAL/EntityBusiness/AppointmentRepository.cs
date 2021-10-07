using DAL.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityBusiness
{
    public class AppointmentRepository : IAppointmentRepository
    {
        CrmsystemContext context = new CrmsystemContext();

        public AppointmentRepository(CrmsystemContext _context)
        {
            context = _context;
        }

        public void CreateAppointment(Appointment appointment)
        {
            context.Appointment.Add(appointment);
            context.SaveChanges();
        }

        public Appointment GetAppointment(Appointment appointment)
        {
            return context.Appointment.Find(appointment);
        }
    }
}
