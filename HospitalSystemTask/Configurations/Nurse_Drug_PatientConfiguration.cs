using HospitalSystemTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Configurations
{
    internal class Nurse_Drug_PatientConfiguration : IEntityTypeConfiguration<Nurse_Drug_Patient>
    {
        public void Configure(EntityTypeBuilder<Nurse_Drug_Patient> NDP)
        {
            NDP.HasKey(ndp => new { ndp.Pat_Id, ndp.Date, ndp.Time });

            NDP
                .HasOne(X=>X.Patient)
                .WithMany(P=>P.Nurse_Drug_Patients)
                .HasForeignKey(X=>X.Pat_Id)
                .OnDelete(DeleteBehavior.Restrict);

            NDP
                .HasOne(X => X.Nurse)
                .WithMany(N => N.Nurse_Drug_Patients)
                .HasForeignKey(X => X.Nur_Num)
                .OnDelete(DeleteBehavior.Restrict);

            NDP
                .HasOne(X => X.Drug)
                .WithMany(D => D.Nurse_Drug_Patients)
                .HasForeignKey(X => X.Drug_Code)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
