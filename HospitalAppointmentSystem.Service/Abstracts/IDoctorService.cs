

using HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Responses;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IDoctorService
{
    List<DoctorResponseDto> GetAll();

    DoctorResponseDto GetById(Guid id);

    Doctor Add(CreateDoctorRequest create);

}
