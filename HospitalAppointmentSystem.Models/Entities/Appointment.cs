

using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public class Appointment : Entity<Guid>
{
    public Guid Id { get; set; }
    public Guid PatientName { get; set; }
    public DateTime AppointmentDate { get; set; }

}
