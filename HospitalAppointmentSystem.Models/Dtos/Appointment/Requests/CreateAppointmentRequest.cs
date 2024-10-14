

namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;

public sealed record CreateAppointmentRequest(string PatientName, DateTime AppointmentDate, int DoctorId);
