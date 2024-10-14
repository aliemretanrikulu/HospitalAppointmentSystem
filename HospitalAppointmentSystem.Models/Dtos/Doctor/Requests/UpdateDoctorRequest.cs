
namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;

public sealed record UpdateDoctorRequest (int Id, Enum Branch, List<string> Patients);
