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

        public List<DoctorResponseDto> GetAll()
        {
            List<Doctor> doctors = _doctorRepository.GetAll();
            List<DoctorResponseDto> doctorResponseDtos = new List<DoctorResponseDto>();
            return doctorResponseDtos;
        }

        public Doctor Add(CreateDoctorRequest create)
        {
            Doctor doctor = _mapper.Map<Doctor>(create);
            Doctor createdDoctor = _doctorRepository.Add(doctor);
            return createdDoctor;
        }

        public Doctor Delete(int id)
        {
            Doctor doctor = _doctorRepository.GetById(id);

            if (doctor is null)
            {

                throw new KeyNotFoundException("Doktor bulunamadı");
            }

            Doctor deletedDoctor = _doctorRepository.Remove(doctor);
            return deletedDoctor;
        }


        public Doctor Update(UpdateDoctorRequest update)
        {
            Doctor existingDoctor = _doctorRepository.GetById(update.Id);

            if (existingDoctor is null)
            {

                throw new KeyNotFoundException("Doktor bulunamadı");
            }

            Doctor updatedDoctor = _doctorRepository.Update(existingDoctor);
            return updatedDoctor;

        }

        public DoctorResponseDto GetById(int id)
        {
            Doctor doctor = _doctorRepository.GetById(id);

            if (doctor is null)
            {
                throw new KeyNotFoundException("Doktor bulunamadı");
            }

            DoctorResponseDto doctorDto = _mapper.Map<DoctorResponseDto>(doctor);
            return doctorDto;
        }

        public Task<object> GetAllDoctorsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
