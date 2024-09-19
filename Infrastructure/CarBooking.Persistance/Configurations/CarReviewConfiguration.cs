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
    public class CarReviewConfiguration : IEntityTypeConfiguration<CarReview>
    {
        public void Configure(EntityTypeBuilder<CarReview> builder)
        {
           
            builder.Property(r => r.Rating)
                   .IsRequired();
                   

            
            builder.Property(r => r.Comment)
                   .HasMaxLength(1000);

            
            builder.Property(r => r.CreatedDate)
                   .IsRequired();

            

          
            builder.HasOne(r => r.AppUser)
                   .WithMany(u => u.CarReviews)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Cascade); // Kullanıcı silinince, ilişkili yorumları da sil

         
            builder.HasOne(r => r.Car)
                   .WithMany(c => c.CarReviews)
                   .HasForeignKey(r => r.CarId)
                   .OnDelete(DeleteBehavior.Cascade); // Araç silinince, ilişkili yorumları da sil
        }
    }
}
