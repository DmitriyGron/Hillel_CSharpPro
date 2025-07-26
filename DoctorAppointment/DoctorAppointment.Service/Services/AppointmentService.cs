﻿using DoctorAppointment.Data.Classes;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;

namespace DoctorAppointment.Service.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IInfoDisplayer<Appointment> _appointmentInfoDisplayer;

        public AppointmentService()
        {
            _appointmentRepository = new AppointmentRepository();
            _appointmentInfoDisplayer = new AppointmentInfoDisplayer();
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
        public void ShowInfo(Appointment appointment)
        {
            _appointmentInfoDisplayer.ShowInfo(appointment);
        }
    }
}
