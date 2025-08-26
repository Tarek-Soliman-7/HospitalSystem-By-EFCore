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
    internal class Patient_ConConfiguration : IEntityTypeConfiguration<Patient_Con>
    {
        public void Configure(EntityTypeBuilder<Patient_Con> PC)
        {
            PC.HasKey(pc => new { pc.Con_Id, pc.Pat_Id });

            PC
                .HasOne(PC=>PC.Patient)
                .WithMany(P=>P.Patient_Cons)
                .HasForeignKey(PC=>PC.Pat_Id)
                .OnDelete(DeleteBehavior.Restrict);

            PC
                .HasOne(PC => PC.Consultant)
                .WithMany(P => P.Patient_Cons)
                .HasForeignKey(PC => PC.Con_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
