using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(i => i.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(i => i.LastName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(i => i.Email)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(i => i.PhoneNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.City)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.State)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.ZipCode)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.Country)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.Description)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(i => i.Courses)
            .WithOne(c => c.Instructor)
            .HasForeignKey(c => c.InstructorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}