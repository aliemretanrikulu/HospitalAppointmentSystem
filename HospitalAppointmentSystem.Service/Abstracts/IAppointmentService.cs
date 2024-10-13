using HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Responses;
using HospitalAppointmentSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Service.Abstracts;

public interface IAppointmentService
{
    List<AppointmentResponseDto> GetAll();

    Appointment Add(CreateAppointmentRequest create);

    Appointment Delete(Guid id);

    Appointment Update(UpdateAppointmentRequest update);

    List<AppointmentResponseDto> GetById(Guid id);

}
