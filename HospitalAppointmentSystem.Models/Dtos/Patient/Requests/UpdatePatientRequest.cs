

namespace HospitalAppointmentSystem.Models.Dtos.Patient.Requests;

public sealed record UpdatePatientRequest(int Id, string PatientName, string PatientDescripton);
