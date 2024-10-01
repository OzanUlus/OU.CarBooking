using CarBooking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistance.Configurations
{
    public class CompanyınformationConfiguration : IEntityTypeConfiguration<CompanyInformation>
    {
        public void Configure(EntityTypeBuilder<CompanyInformation> builder)
        {
            builder.HasKey(ci => ci.CompanyInformationId);

    
            builder.Property(ci => ci.Title)
                   .IsRequired()
                   .HasMaxLength(100);

           
            builder.Property(ci => ci.Description)
                   .HasMaxLength(1500);

            
            builder.Property(ci => ci.ImageUrl)
                   .HasMaxLength(200);
        }
    }
}
