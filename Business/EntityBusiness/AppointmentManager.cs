using Business.Interfaces;
using DAL.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.EntityBusiness
{
    public class AppointmentManager : IAppointmentService
    {
        private readonly IAppointmentRepository appointmentRepository;

        public AppointmentManager(IAppointmentRepository _appointmentRepository)
        {
            appointmentRepository = _appointmentRepository;
        }

        public void CreateAppointment(Appointment appointment)
        {
            appointmentRepository.CreateAppointment(appointment);
        }

        public Appointment GetAppointment(Appointment appointment)
        {
            return appointmentRepository.GetAppointment(appointment);
        }

        public Appointment GetAppointmentByUser(byte statusId = 0, DateTime? time = null)
        {
            return appointmentRepository.GetAppointmentByUser(statusId, time);
        }
    }
}
