using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;

namespace DoctorAppointment.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
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
        public Doctor ShowInfo(Doctor doctor)
        {
            Console.WriteLine($"Name: {doctor.Name}  {doctor.Surname}");
            Console.WriteLine($"Phone: {doctor.Phone}");
            Console.WriteLine($"Email: {doctor.Email}");
            Console.WriteLine($"DoctorType: {doctor.DoctorType}");
            Console.WriteLine($"Experience: {doctor.Experience}");
            Console.WriteLine($"Salary: {doctor.Salary}");
            return _doctorRepository.ShowInfo(doctor);


        }
    }
}