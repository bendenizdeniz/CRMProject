using Entity;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IAppointmentRepository
    {
        Appointment GetAppointment(Appointment appointment);

        void CreateAppointment(Appointment appointment);

        Appointment GetAppointmentByUser(byte statusId = 0, DateTime? time = null);
    }
}

