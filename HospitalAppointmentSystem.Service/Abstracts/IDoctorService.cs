

using HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Responses;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IDoctorService
{
    List<DoctorResponseDto> GetAll();

    Doctor Add(CreateDoctorRequest create);

    Doctor Delete(Guid id);

    Doctor Update(UpdateDoctorRequest update);

    DoctorResponseDto GetById(Guid id);
}
