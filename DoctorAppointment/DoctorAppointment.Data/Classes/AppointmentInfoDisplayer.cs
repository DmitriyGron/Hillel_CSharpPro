using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Data.Classes
{
    public class AppointmentInfoDisplayer : IInfoDisplayer<Appointment>
    {
        public void ShowInfo(Appointment appointment)
        {
            Console.WriteLine($"Patient: {appointment.Patient?.Name ?? "Unknown"} {appointment.Patient?.Surname ?? "Unknown"}");
            Console.WriteLine($"Doctor: {appointment.Doctor?.Name ?? "Unknown"}  {appointment.Doctor?.Surname ?? "Unknown"}");
            Console.WriteLine($"DateTimeFrom: {appointment.DateTimeFrom}");
            Console.WriteLine($"DateTimeTo: {appointment.DateTimeTo}");
            Console.WriteLine($"Description: {appointment.Description ?? "No description"}");
            Console.WriteLine($"Id: {appointment.Id}");
        }
    }
}
