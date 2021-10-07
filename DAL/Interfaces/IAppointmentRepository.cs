using Entity;

namespace DAL.Interfaces
{
    public interface IAppointmentRepository
    {
        Appointment GetAppointment(Appointment appointment);

        void CreateAppointment(Appointment appointment);
    }
}

