

using Core.Repositories;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Contexts;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.DataAccess.Concretes;

public class EfDoctorRepository : EfRepostitoryBase<BaseDbContext, Doctor, Guid>, IDoctorRepository
{
    public EfDoctorRepository(BaseDbContext name) : base(name)
    {

    }
}
