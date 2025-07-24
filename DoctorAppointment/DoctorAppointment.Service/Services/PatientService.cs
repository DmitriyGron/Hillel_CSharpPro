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

        public void ShowInfo(Patient patient)
        {
            _patientRepository.ShowInfo(patient);
        }
    }
}
