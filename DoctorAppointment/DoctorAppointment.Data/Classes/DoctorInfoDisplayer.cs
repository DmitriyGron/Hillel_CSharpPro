using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;
using System.Numerics;

namespace DoctorAppointment.Data.Classes
{
    public class DoctorInfoDisplayer : IInfoDisplayer<Doctor>
    {
        public void ShowInfo(Doctor doctor)
        {
            Console.WriteLine($"Name: {doctor.Name}  {doctor.Surname}");
            Console.WriteLine($"Phone: {doctor.Phone}");
            Console.WriteLine($"Email: {doctor.Email}");
            Console.WriteLine($"DoctorType: {doctor.DoctorType}");
            Console.WriteLine($"Experience: {doctor.Experience}");
            Console.WriteLine($"Salary: {doctor.Salary}");
            Console.WriteLine($"Id: {doctor.Id}");
        }
    }
}
