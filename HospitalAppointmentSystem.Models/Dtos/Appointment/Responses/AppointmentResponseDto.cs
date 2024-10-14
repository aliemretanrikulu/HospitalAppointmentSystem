
namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Responses
{
    public sealed record AppointmentResponseDto(
        string PatientName,
        DateTime AppointmentDate,
        int DoctorId
        );
}