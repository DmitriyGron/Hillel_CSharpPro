using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;
using DoctorAppointment.Service.Services;

namespace DoctorAppointment
{
    public class AppointmentCall
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentCall()
        {
            _appointmentService = new AppointmentService();
        }

        public void Run()
        {
            var appointments = _appointmentService.GetAll();

            foreach (var app in appointments)
            {
                _appointmentService.ShowInfo(app);
                Console.WriteLine("_______________________________________________________________");
            }
        }
    }

    public class PatientAppointment
    {
        private readonly IPatientService _patientService;

        public PatientAppointment()
        {
            _patientService = new PatientService();

        }

        public void Run()
        {

            Console.WriteLine("Current Patient list: ");
            var patients = _patientService.GetAll();

            foreach (var pat in patients)
            {
                _patientService.ShowInfo(pat);
                Console.WriteLine("_______________________________________________________________");
            }
        }
    }

    public class DoctorAppointment
    {
        private readonly IDoctorService _doctorService;

        public DoctorAppointment()
        {
            _doctorService = new DoctorService();
        }

        public void Menu()
        {
            //while (true)
            //{
            //    //add enum for menu items and describe menu

            //}
            Console.WriteLine("Current doctors list: ");
            var docs = _doctorService.GetAll();

            foreach (var doc in docs)
            {
                _doctorService.ShowInfo(doc);
                Console.WriteLine("_______________________________________________________________");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var doctorAppointment = new DoctorAppointment();
            doctorAppointment.Menu();


            var patientAppointment = new PatientAppointment();
            patientAppointment.Run();

            var appointmentCall = new AppointmentCall();
            appointmentCall.Run();
        }
    }
}