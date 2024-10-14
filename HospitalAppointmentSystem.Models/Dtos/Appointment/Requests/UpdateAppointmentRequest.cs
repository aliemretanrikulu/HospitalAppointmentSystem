

namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;

public sealed record UpdateAppointmentRequest(int Id , string PatientName, DateTime AppointmentDate, int DoctorId);
