

namespace HospitalAppointmentSystem.Models.Dtos.Patient.Response;

public sealed record PatientResponseDto(
    int Id,
    string PatientName,
    string PatientDescription
    );