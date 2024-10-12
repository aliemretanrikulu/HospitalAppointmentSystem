
namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;

public sealed record CreateDoctorRequest (Enum Branch, List<string> Patients);
