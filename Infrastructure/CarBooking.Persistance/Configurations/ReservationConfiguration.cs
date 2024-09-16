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
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
           
            builder.Property(r => r.StartDate)
                   .IsRequired();

            builder.Property(r => r.EndDate)
                   .IsRequired();

           
            builder.Property(r => r.TotalPrice)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)"); // Para birimi formatı

           
            builder.Property(r => r.ReservationStatus)
                   .IsRequired();

            
            builder.Property(r => r.CreatedDate)
                   .IsRequired();

           
            builder.Property(r => r.UpdatedDate)
                   .IsRequired(false);

            // Car ile ilişki (N-1)
            builder.HasOne(r => r.Car)
                   .WithMany(c => c.Reservations)
                   .HasForeignKey(r => r.CarId)
                   .OnDelete(DeleteBehavior.Cascade); // Araç silinince, ilişkili rezervasyonları da sil

            // AppUser ile ilişki (N-1)
            builder.HasOne(r => r.AppUser)
                   .WithMany(u => u.Reservations)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Cascade); // Kullanıcı silinince, ilişkili rezervasyonları da sil

           
        }
    }
}
