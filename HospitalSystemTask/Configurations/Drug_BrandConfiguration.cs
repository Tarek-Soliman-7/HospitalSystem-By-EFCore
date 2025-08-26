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
    internal class Drug_BrandConfiguration : IEntityTypeConfiguration<Drug_Brand>
    {
        public void Configure(EntityTypeBuilder<Drug_Brand> DB)
        {
            DB.HasKey(db => new { db.Code, db.Brand });

            DB
                .HasOne(DB=>DB.Drug)
                .WithMany(D=>D.Brands)
                .HasForeignKey(DB=>DB.Code)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
