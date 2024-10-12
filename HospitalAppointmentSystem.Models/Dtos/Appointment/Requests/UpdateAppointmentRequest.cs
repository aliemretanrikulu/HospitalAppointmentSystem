

namespace HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;

public sealed record UpdateAppointmentRequest(Guid PatientName, DateTime AppointmentDate, int DoctorId);
