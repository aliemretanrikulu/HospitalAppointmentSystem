
using Core.Entities;

namespace HospitalAppointmentSystem.Models.Entities;

public sealed class Doctor : Entity<Guid>
{

    public enum Branch
    {
        Orthopedics,
        Ophthalmology,
        Dermatology,
        Cardiology
    }

    public List<string> Patients { get; set; } = new List<string>(); 
}
