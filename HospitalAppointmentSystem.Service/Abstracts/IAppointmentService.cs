using HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Responses;
using HospitalAppointmentSystem.Models.Entities;
namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IAppointmentService
{
    List<AppointmentResponseDto> GetAll();
    AppointmentResponseDto GetById(Guid id);

    Appointment Add(CreateAppointmentRequest create);

    Appointment Delete(Guid id);

    Appointment Update(UpdateAppointmentRequest update);
}
