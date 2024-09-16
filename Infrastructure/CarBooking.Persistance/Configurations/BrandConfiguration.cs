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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
          
            builder.Property(b => b.BrandName)
                   .IsRequired()
                   .HasMaxLength(100);

           
            builder.Property(b => b.BrandImageUrl)
                   .IsRequired()
                   .HasMaxLength(500);

            // Cars ile ilişki (1-N)
            builder.HasMany(b => b.Cars)
                   .WithOne(c => c.Brand) 
                   .HasForeignKey(c => c.BrandId) 
                   .OnDelete(DeleteBehavior.Cascade); // Brand silinince, ilişkili arabaları da sil
        }
    }
}
