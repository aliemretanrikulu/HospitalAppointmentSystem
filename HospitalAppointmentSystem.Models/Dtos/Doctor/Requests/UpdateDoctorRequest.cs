
namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;

public sealed record UpdateDoctorRequest (Guid Id, Enum Branch, List<string> Patients);
