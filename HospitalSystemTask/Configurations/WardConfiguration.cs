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
    internal class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> W)
        {
            W
                .HasOne(x => x.Supervisor)
                .WithOne(y => y.SupervisedWard)
                .HasForeignKey<Ward>(z => z.Nurse_Num)
                .OnDelete(DeleteBehavior.Restrict);

            W
                .HasMany(W=>W.Nurses)
                .WithOne(N=>N.Ward)
                .HasForeignKey(N=>N.Ward_Id)
                .OnDelete(DeleteBehavior.Restrict);

            W
                .HasMany(W => W.Patients)
                .WithOne(N => N.Ward)
                .HasForeignKey(N => N.Ward_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
