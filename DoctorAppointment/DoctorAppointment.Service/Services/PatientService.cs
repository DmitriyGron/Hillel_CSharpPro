using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;

namespace DoctorAppointment.Service.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService()
        {
            _patientRepository = new PatientRepository();
        }
        public Patient Create(Patient patient)
        {
            return _patientRepository.Create(patient);
        }
        public IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }
        public Patient? Get(int id)
        {
            return _patientRepository.GetById(id);
        }
        public bool Delete(int id)
        {
            return _patientRepository.Delete(id);
        }
        public Patient Update(int id, Patient patient)
        {
            return _patientRepository.Update(id, patient);
        }

        public Patient ShowInfo(Patient patient)
        {
            Console.WriteLine($"Name: {patient.Name}  {patient.Surname}");
            Console.WriteLine($"Phone: {patient.Phone}");
            Console.WriteLine($"Email: {patient.Email}");
            Console.WriteLine($"IllnessType: {patient.IllnessType}");
            Console.WriteLine($"AddittionalInfo: {patient.AddittionalInfo}");
            Console.WriteLine($"Address: {patient.Address}");
            return _patientRepository.ShowInfo(patient);
        }
    }
}
