using DoctorAppointment.Data.Configuration;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;
using Newtonsoft.Json;

namespace DoctorAppointment.Data.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public override string Path { get; set; }
        public override int LastId { get; set; }

        public DoctorRepository()
        {
            dynamic result = ReadFromAppSettings();

            Path = result.Database.Doctors.Path;
            LastId = result.Database.Doctors.LastId;
        }

        public override void ShowInfo(Doctor doctor)
        {
            Console.WriteLine($"Id: {doctor.Id}");
            Console.WriteLine($"Name: {doctor.Name} {doctor.Surname}");
            Console.WriteLine($"Type: {doctor.DoctorType} ({(Domain.Enums.DoctorTypes)doctor.DoctorType})");
            Console.WriteLine($"Experience: {doctor.Experience} years");
            Console.WriteLine($"Salary: {doctor.Salary}");
            Console.WriteLine($"Phone: {doctor.Phone ?? "N/A"}");
            Console.WriteLine($"Email: {doctor.Email ?? "N/A"}");
            Console.WriteLine($"Created At: {doctor.CreatedAt}");
            Console.WriteLine($"Updated At: {doctor.UpdatedAt}");
            Console.WriteLine(new string('-', 30));
        }

        protected override void SaveLastId()
        {
            dynamic result = ReadFromAppSettings();
            result.Database.Doctors.LastId = LastId;

            File.WriteAllText(Constants.AppSettingsPath, result.ToString());
        }
    }
}
