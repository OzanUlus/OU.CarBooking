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
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            
            builder.Property(i => i.ImageUrl)
                   .IsRequired()
                   .HasMaxLength(500);

            // Car ile ilişki (N-1)
            builder.HasOne(i => i.Car)
                   .WithMany(c => c.Images)
                   .HasForeignKey(i => i.CarId)
                   .OnDelete(DeleteBehavior.Cascade); // Araç silinince, ilişkili görselleri de sil
        }
    }
}
