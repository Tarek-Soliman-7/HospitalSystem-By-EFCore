using HospitalSystemTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Data
{
    internal class HospitalDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database= HospitalSystem; Trusted_Connection=true; trustservercertificate=true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Nurse_Drug_Patient> nurse_Drug_Patients { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Patient_Con> Patient_Cons { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Drug_Brand> Drug_Brands { get; set; }
    }
}
