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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
           
            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            
            builder.Property(u => u.Address)
                   .IsRequired()
                   .HasMaxLength(200);

            // Payments ile ilişki (1-N) tanımlama
            builder.HasMany(u => u.Payments)
                   .WithOne(p=>p.AppUser)
                   .HasForeignKey(p=>p.UserId) 
                   .OnDelete(DeleteBehavior.Cascade); // Kullanıcı silinince, ilişkili ödemeleri de sil
        }
    }
}
