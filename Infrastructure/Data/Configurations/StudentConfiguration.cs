using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(s => s.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Email)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.PhoneNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.City)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.State)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.ZipCode)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Country)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Description)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(s => s.Courses)
            .WithMany(c => c.Students);
    }
}