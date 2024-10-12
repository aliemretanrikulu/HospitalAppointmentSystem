

namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;

public sealed record CreateAppointmentRequest(Guid PatientName, DateTime AppointmentDate, int DoctorId);
