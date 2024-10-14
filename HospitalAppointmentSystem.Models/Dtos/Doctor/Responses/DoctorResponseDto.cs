

using Core.Enum;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Responses;

namespace HospitalAppointmentSystem.Models.Dtos.Doctor.Responses;

public sealed record DoctorResponseDto(
    int Id,
    string Name,
    string Branch,
    List<AppointmentResponseDto> Appointments
    );

