using DoctorAppointment.Data.Classes;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;

namespace DoctorAppointment.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IInfoDisplayer<Doctor> _doctorInfoDisplayer;

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
            _doctorInfoDisplayer = new DoctorInfoDisplayer();
        }

        public Doctor Create(Doctor doctor)
        {
            return _doctorRepository.Create(doctor);
        }

        public bool Delete(int id)
        {
            return _doctorRepository.Delete(id);
        }

        public Doctor? Get(int id)
        {
            return _doctorRepository.GetById(id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _doctorRepository.GetAll();
        }

        public Doctor Update(int id, Doctor doctor)
        {
            return _doctorRepository.Update(id, doctor);
        }
        public void ShowInfo(Doctor doctor)
        {
            _doctorInfoDisplayer.ShowInfo(doctor);
        }
    }
}