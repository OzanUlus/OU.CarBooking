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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

            builder.Property(c => c.Model)
                   .IsRequired()
                   .HasMaxLength(100);


            builder.Property(c => c.Yaer)
                   .IsRequired()
                   .HasMaxLength(4);


            builder.Property(c => c.LicensePlate)
                   .IsRequired()
                   .HasMaxLength(20);


            builder.Property(c => c.TransmissionType)
                   .IsRequired();

            builder.Property(c => c.FuelType)
                   .IsRequired();


            builder.Property(c => c.SeatCount)
                   .IsRequired();

            builder.Property(c => c.PricePerDay)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");


            builder.Property(c => c.AvailabilityStatus)
                   .IsRequired();



            // Location ile ilişki (N-1)
            builder.HasOne(c => c.Location)
                   .WithMany(l => l.Cars)
                   .HasForeignKey(c => c.LocationId)
                   .OnDelete(DeleteBehavior.Restrict); // Silme davranışı belirlenebilir


        }
    }
}

