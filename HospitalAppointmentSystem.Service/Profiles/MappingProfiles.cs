

using AutoMapper;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Requests;
using HospitalAppointmentSystem.Models.Dtos.Appointment.Responses;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Responses;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateDoctorRequest, Doctor>();
        CreateMap<CreateAppointmentRequest, Appointment>();

        CreateMap<Doctor, DoctorResponseDto>().ReverseMap();
        CreateMap<Appointment, AppointmentResponseDto>().ReverseMap();

    }
}
