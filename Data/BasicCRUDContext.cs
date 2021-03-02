using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUD.Data
{
    public class BasicCRUDContext : DbContext
    {
        public BasicCRUDContext(DbContextOptions<BasicCRUDContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
        }
    }
}
