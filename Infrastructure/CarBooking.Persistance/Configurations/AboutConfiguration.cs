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
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(a => a.AboutId);

            // Title configuration
            builder.Property(a => a.Title)
                .IsRequired()         // Title is required
                .HasMaxLength(300);    // Max length of 100 characters

            // Description configuration
            builder.Property(a => a.Description)
                .IsRequired()         // Description is required
                .HasMaxLength(2000);    // Max length of 500 characters

            // ImageUrl configuration
            builder.Property(a => a.ImageUrl)
                .IsRequired()         // ImageUrl is required
                .HasMaxLength(200);    // Max length of 200 characters
        }
    }
}
