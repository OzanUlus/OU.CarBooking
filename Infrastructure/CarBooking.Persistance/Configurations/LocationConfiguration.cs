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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
           
            builder.Property(l => l.City)
                   .IsRequired()
                   .HasMaxLength(100);

           
            builder.Property(l => l.Address)
                   .IsRequired()
                   .HasMaxLength(250);

            
            builder.Property(l => l.ContactNumber)
                   .HasMaxLength(15);

            
          
        }
    }
}
