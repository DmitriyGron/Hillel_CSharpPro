using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Data.Interfaces
{
    public interface IDoctorRepository : IGenericRepository<Doctor>
    {
        //  you can add more specific methods for Doctor repository if needed
    }
}
