

namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Responses;

public sealed record DoctorResponseDto(
    Guid Id,
    string Name,
    Enum Branch,
    List<string> Patients
    );

