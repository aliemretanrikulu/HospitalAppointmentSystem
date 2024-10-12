
namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Responses
{
    public sealed record AppointmentResponseDto(
        Guid PatientName,
        DateTime AppointmentDate,
        int DoctorId
        );
}