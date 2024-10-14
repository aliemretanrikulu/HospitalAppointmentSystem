
using Core.Enum;

namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;

public sealed record UpdateDoctorRequest (int Id, BranchEnum Branch, List<string> Patients);
