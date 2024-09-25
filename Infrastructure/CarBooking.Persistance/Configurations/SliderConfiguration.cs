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
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            // Primary key
            builder.HasKey(s => s.SliderId);

            // Property ayarları
            builder.Property(s => s.ImageUrl1)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(s => s.Title1)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.Description1)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(s => s.ImageUrl2)
                .HasMaxLength(500);

            builder.Property(s => s.Title2)
                .HasMaxLength(100);

            builder.Property(s => s.Description2)
                .HasMaxLength(500);

            builder.Property(s => s.ImageUrl3)
                .HasMaxLength(500);

            builder.Property(s => s.Title3)
                .HasMaxLength(100);

            builder.Property(s => s.Description3)
                .HasMaxLength(500);
        }
    }
}
