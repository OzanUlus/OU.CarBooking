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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {

            builder.Property(p => p.Amount)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");


            

            builder.Property(p => p.PaymentDate)
                   .IsRequired();

            // Reservation ile ilişki (N-1)
            builder.HasOne(p => p.Reservation)
           .WithOne(r => r.Payment) 
           .HasForeignKey<Payment>(p => p.ReservationId) 
           .OnDelete(DeleteBehavior.NoAction); 



        }
    }
}
