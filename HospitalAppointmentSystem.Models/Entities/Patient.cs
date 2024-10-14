
using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public class Patient : Entity<Guid>
{
    public int PatientId { get; set; }
    public string PatientName { get; set; }

    public string PatientDescription { get; set; }


}
