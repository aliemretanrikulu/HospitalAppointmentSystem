using Core.Enum;
using HospitalAppointmentSystem.Models.Dtos.Patient.Response;
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
        private readonly DbContext _context; 
        private readonly IDoctorService _doctorService;

        public DoctorsController(DbContext context, IDoctorService doctorService)
        {
            _context = context;
            _doctorService = doctorService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await _doctorService.GetAllDoctorsAsync();
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
            var doctor = await _context.Doctor.FindAsync(id);
            if (doctor == null)
            {
                return NotFound("Doktor bulunamadı");
            }
            return Ok(doctor);
        }
    }
}
