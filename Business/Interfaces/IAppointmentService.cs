using Entity;

namespace Business.Interfaces
{
    public interface IAppointmentService
    {
        Appointment GetAppointment(Appointment appointment);

        void CreateAppointment(Appointment appointment);
    }
}
