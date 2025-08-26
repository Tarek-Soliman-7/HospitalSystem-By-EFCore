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
    internal class ConsultantConfiguration : IEntityTypeConfiguration<Consultant>
    {
        public void Configure(EntityTypeBuilder<Consultant> C)
        {
            C
                 .HasMany(C => C.Patients)
                 .WithOne(P => P.Consultant)
                 .HasForeignKey(P => P.Con_Id)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
