

namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;

public sealed record UpdateAppointmentRequest(Guid Id , string PatientName, DateTime AppointmentDate, int DoctorId);
