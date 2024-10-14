using Core.Enum;
using HospitalAppointmentSystem.Models.Dtos.Doctor.Requests;
using HospitalAppointmentSystem.Models.Entities;
using HospitalAppointmentSystem.Service.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var doctors =  _doctorService.GetAll();
            return CreateActionResult(doctors);
        }

        private IActionResult CreateActionResult<T>(T result)
        {
            if (result == null)
            {
                return NotFound("Doktor bulunamadı");
            }
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var doctor = _doctorService.GetById(id);
            if (doctor == null)
            {
                return NotFound("Doktor bulunamadı");
            }
            return Ok(doctor);
        }
        [HttpPost("add")]
        public IActionResult Add([FromQuery] CreateDoctorRequest doctor)
        {
            var added = _doctorService.Add(doctor);
            if (doctor == null)
            {
                return NotFound("Doktor bulunamadı");
            }
            return Ok(doctor);
        }
    }
}
