

using HospitalAppointmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.DataAccess.Contexts;

public class BaseDbContext : DbContext 
{
    public BaseDbContext(DbContextOptions opt) : base(opt) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1907;Database = HospitalAppointment_DB; User=sa; Password=admin123456789;TrustServerCertificate=true");
    }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}