using HospitalAppointmentSystem.Models.Dtos.Patient.Response;
using HospitalAppointmentSystem.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{

    static List<Patient> Patients = new List<Patient>
    {
        new Patient { PatientId = 1, PatientName = "Ahmmet", PatientDescription = "Kardiyoloji hastası" },
        new Patient { PatientId = 2, PatientName = "Kadir", PatientDescription = "Cilt hastası" },
        new Patient { PatientId = 3, PatientName = "Öznur", PatientDescription = "Göz hastası" }
 };

    [HttpGet]
    public List<Patient> GetAll()
    {
        return Patients.ToList();
    }

    [HttpGet("getbyid")]
    public Patient GetById([FromQuery] int id)
    {
        Patient patient = Patients.SingleOrDefault(x=> x.PatientId==id);
        return patient;
    }

}