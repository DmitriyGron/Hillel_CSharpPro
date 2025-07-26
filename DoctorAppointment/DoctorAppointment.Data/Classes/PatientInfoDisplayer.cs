using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Data.Classes
{
    public class PatientInfoDisplayer : IInfoDisplayer<Patient>
    {
        public void ShowInfo(Patient patient)
        {
            Console.WriteLine($"Name: {patient.Name}  {patient.Surname}");
            Console.WriteLine($"Phone: {patient.Phone}");
            Console.WriteLine($"Email: {patient.Email}");
            Console.WriteLine($"IllnessType: {patient.IllnessType}");
            Console.WriteLine($"AddittionalInfo: {patient.AddittionalInfo}");
            Console.WriteLine($"Address: {patient.Address}");
            Console.WriteLine($"Id: {patient.Id}");
        }
    }
}
