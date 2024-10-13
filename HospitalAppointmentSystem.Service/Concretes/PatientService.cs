

using AutoMapper;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;
using HospitalAppointmentSystem.Models.Dtos.Patient.Response;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;

namespace HospitalAppointmentSystem.Service.Concretes;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;
    private readonly IMapper _mapper;

    public Patient Add(CreateAppointmentRequest create)
    {
        Patient patient = _mapper.Map<Patient>(create);
        Patient createdPatient = _patientRepository.Add(patient);
        return patient;
    }

    public List<PatientResponseDto> GetAll()
    {
        List<Patient> patients = _patientRepository.GetAll();

    }

    public Patient Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Patient Update(UpdateAppointmentRequest update)
    {
        throw new NotImplementedException();
    }

    public List<PatientResponseDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
