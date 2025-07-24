﻿using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;

namespace DoctorAppointment.Service.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService()
        {
            _appointmentRepository = new AppointmentRepository();
        }

        public Appointment Create(Appointment appointment)
        {
            return _appointmentRepository.Create(appointment);
        }

        public bool Delete(int id)
        {
            return _appointmentRepository.Delete(id);
        }

        public Appointment? Get(int id)
        {
            return _appointmentRepository.GetById(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _appointmentRepository.GetAll();
        }

        public Appointment Update(int id, Appointment appointment)
        {
            return _appointmentRepository.Update(id, appointment);
        }
        public Appointment ShowInfo(Appointment appointment)
        {
            Console.WriteLine($"Patient: {appointment.Patient?.Name ?? "Unknown"} {appointment.Patient?.Surname ?? "Unknown"}");
            Console.WriteLine($"Doctor: {appointment.Doctor?.Name ?? "Unknown"}  {appointment.Doctor?.Surname ?? "Unknown"}");
            Console.WriteLine($"DateTimeFrom: {appointment.DateTimeFrom}");
            Console.WriteLine($"DateTimeTo: {appointment.DateTimeTo}");
            Console.WriteLine($"Description: {appointment.Description ?? "No description"}");
            return _appointmentRepository.ShowInfo(appointment);
        }

    }
}
