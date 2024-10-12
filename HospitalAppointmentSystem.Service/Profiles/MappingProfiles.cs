

using AutoMapper;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateDoctorRequest, Doctor>();
    }
}
