using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Data.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        //  you can add more specific methods for Doctor repository if needed
    }
}
