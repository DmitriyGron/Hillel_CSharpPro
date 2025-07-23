using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;
using DoctorAppointment.Service.Services;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment
{
    public class  PatientAppointment
    {
        private readonly IPatientService _patientService;

        public PatientAppointment()
        {
            _patientService = new PatientService();
        }

        public void Run()
        {
            Console.WriteLine("Current Patient list: ");
            var patient = _patientService.GetAll();

            foreach (var pat in patient)
            {
                Console.WriteLine(pat.Name);
            }

            Console.WriteLine("Adding patient: ");
            var newPatient = new Patient
            {
                Name = "Oleg",
                Surname = "Gydrov",
                IllnessType = Domain.Enums.IllnessTypes.Ambulance,
                AddittionalInfo = "No additional info",
                Address = "Kyiv, Ukraine",
                Phone = "123-456-7890",
                Email = "unvmj5105775@mail.com"
            };

            _patientService.Create(newPatient);
            Console.WriteLine("Current doctors list: ");
            patient = _patientService.GetAll();

            foreach (var pat in patient)
            {
                Console.WriteLine(pat.Name);
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
            while (true)
            {
                //add enum for menu items and describe menu
                
            }

            //Console.WriteLine("Current doctors list: ");
            //var docs = _doctorService.GetAll();

            //foreach (var doc in docs)
            //{
            //    Console.WriteLine(doc.Name);
            //}

            //Console.WriteLine("Adding doctor: ");
            //var newDoctor = new Doctor
            //{
            //    Name = "Dr. Smith",
            //    Surname = "Petrov",
            //    Experience = 11,
            //    DoctorType = Domain.Enums.DoctorTypes.Dentist
            //};

            //_doctorService.Create(newDoctor);
            //Console.WriteLine("Current doctors list: ");
            //docs = _doctorService.GetAll();

            //foreach (var doc in docs)
            //{
            //    Console.WriteLine(doc.Name);
            //}


            
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //var doctorAppointment = new DoctorAppointment();
            //doctorAppointment.Menu();

            var patientAppointment = new PatientAppointment();
            patientAppointment.Run();

        }
    }
}