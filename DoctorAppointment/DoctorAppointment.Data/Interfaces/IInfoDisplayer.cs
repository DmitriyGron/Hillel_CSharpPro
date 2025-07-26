namespace DoctorAppointment.Data.Interfaces
{
    public interface IInfoDisplayer<TSource>
    {
        void ShowInfo(TSource source);
    }
}
