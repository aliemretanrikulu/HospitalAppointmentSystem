using AutoMapper;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Responses;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Service.Concretes
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public Doctor Add(CreateDoctorRequest create)
        {
            Doctor doctor = _mapper.Map<Doctor>(create);
            Doctor createdDoctor = _doctorRepository.Add(doctor);
            return createdDoctor;
        }


        public List<DoctorResponseDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public DoctorResponseDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
