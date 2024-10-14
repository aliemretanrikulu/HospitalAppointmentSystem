using Core.Repositories;
using HospitalAppointmentSystem.DataAccess.Abstracts;
using HospitalAppointmentSystem.DataAccess.Contexts;
using HospitalAppointmentSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.DataAccess.Concretes
{
    public class EfAppointmentRepository : EfRepostitoryBase<BaseDbContext, Appointment, Guid>, IAppointmentRepository
    {
        public EfAppointmentRepository(BaseDbContext name) : base(name)
        {

        }

        public Appointment GetById(int doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
