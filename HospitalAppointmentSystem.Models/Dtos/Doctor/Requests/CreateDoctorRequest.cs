
using Core.Enum;

namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;

public sealed record CreateDoctorRequest (string Name,BranchEnum Branch);
