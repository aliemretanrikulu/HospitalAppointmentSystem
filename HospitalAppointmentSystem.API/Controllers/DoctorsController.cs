using HospitalAppointmentSystem.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorsController : ControllerBase
{
    [HttpGet("getdoctor")]
    public Doctor GetDoctor()
    {
        return new Doctor
        {
            Id = Guid.NewGuid(),
            Name = "Emre",
            Patients = ,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
        };
    }
}