

using HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;
using HospitalAppointmentSystem.Models.Dtos.Patient.Response;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IPatientService
{
    List<PatientResponseDto> GetAll();

    Patient Add(CreateAppointmentRequest create);

    Patient Delete(Guid id);

    Patient Update(UpdateAppointmentRequest update);

    List<PatientResponseDto> GetById(Guid id);

    

    
}
