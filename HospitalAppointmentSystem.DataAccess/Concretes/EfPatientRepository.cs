

using Core.Repositories;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Contexts;
using HospitalAppointmentSystem.Models.Entities;

namespace HospitalAppointmentSystem.DataAccess.Concretes;

public class EfPatientRepository : EfRepostitoryBase<BaseDbContext, Patient, Guid>, IPatientRepository
{
    public EfPatientRepository(BaseDbContext name) : base(name)
    {

    }
}
