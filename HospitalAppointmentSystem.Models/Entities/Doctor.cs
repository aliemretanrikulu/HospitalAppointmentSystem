
using Core.Entities;
using Core.Enum;

namespace HospitalAppointmentSystem.Models.Entities;

public sealed class Doctor : Entity<int>
{
    public string Name { get; set; }

    public BranchEnum Branch { get; set; }

    public List<Appointment> Patients { get; set; } = new List<Appointment>(); 
}
