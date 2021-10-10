using Entity;
using System;

namespace Business.Interfaces
{
    public interface IAppointmentService
    {
        Appointment GetAppointment(Appointment appointment);

        void CreateAppointment(Appointment appointment);

        Appointment GetAppointmentByUser(byte statusId = 0, DateTime? time = null);
    }
}
