using DoctorAppointment.Data.Configuration;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;
using Newtonsoft.Json;
using System.Numerics;

namespace DoctorAppointment.Data.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public override string Path { get; set; }
        public override int LastId { get; set; }

        public PatientRepository()
        {
            dynamic result = ReadFromAppSettings();

            Path = result.Database.Patients.Path;
            LastId = result.Database.Patients.LastId;
        }

        public override void ShowInfo(Patient patient)
        {
            Console.WriteLine($"Id: {patient.Id}");
            Console.WriteLine($"Name: {patient.Name} {patient.Surname}");
            Console.WriteLine($"Phone: {patient.Phone ?? "N/A"}");
            Console.WriteLine($"Email: {patient.Email ?? "N/A"}");
            Console.WriteLine($"Created At: {patient.CreatedAt}");
            Console.WriteLine($"Updated At: {patient.UpdatedAt}");
            Console.WriteLine($"Address: {patient.Address ?? "N/A"}");
            Console.WriteLine($"Additional Info: {patient.AddittionalInfo ?? "N/A"}");
            Console.WriteLine(new string('-', 30));
        }


        protected override void SaveLastId()
        {
            dynamic result = ReadFromAppSettings();
            result.Database.Patients.LastId = LastId;

            File.WriteAllText(Constants.AppSettingsPath, result.ToString());
        }
    }
}
