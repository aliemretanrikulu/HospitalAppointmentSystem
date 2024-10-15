using AutoMapper;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Concretes;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Responses;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;

namespace HospitalAppointmentSystem.Service.Concretes;

public class AppointmentService : IAppointmentService
{
   
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMapper _mapper;

    public AppointmentService(IAppointmentRepository appointmentRepository, IMapper mapper)
    {
        _appointmentRepository = appointmentRepository;
        _mapper = mapper;
    }

    public List<AppointmentResponseDto> GetAll()
    {
        List<Appointment> appointments = _appointmentRepository.GetAll();
        List<AppointmentResponseDto> appointmentDtos = _mapper.Map<List<AppointmentResponseDto>>(appointments);
        return appointmentDtos;
    }

    public Appointment Add(CreateAppointmentRequest create)
    {
        Appointment appointment = new Appointment();
        Appointment createdAppointment = _appointmentRepository.Add(appointment);
        return createdAppointment;
    }

    public Appointment Delete(Guid id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);

        if (appointment is null)
        {
            throw new KeyNotFoundException("Randevu bulunamadı");
        }

        Appointment deletedAppointment = _appointmentRepository.Remove(appointment);
        return deletedAppointment;
    }

    public Appointment Update(UpdateAppointmentRequest update)
    {
        Appointment existingAppointment = _appointmentRepository.GetById(update.Id);

        if (existingAppointment is null)
        {
            throw new KeyNotFoundException("Randevu bulunamadı");
        }

        Appointment updatedAppointment = _appointmentRepository.Update(existingAppointment);
        return updatedAppointment;
    }


    public AppointmentResponseDto GetById(Guid id)
    {
        Appointment appointment = _appointmentRepository.GetById(id);

        if (appointment is null)
        {
            throw new KeyNotFoundException("Randevu bulunamadı");
        }

        AppointmentResponseDto appointmentDto = _mapper.Map<AppointmentResponseDto>(appointment);
        return appointmentDto;
    }
}

