

using Core.Repositories;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.DataAccess.Abstracts;

public interface IPatientRepository : IRepository<Patient, Guid>
{

}
