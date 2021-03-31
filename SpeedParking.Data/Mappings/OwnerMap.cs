using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpeedParking.Domain.Entities;

namespace SpeedParking.Data.Mappings
{
    public class OwnerMap : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("Owner");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Name).HasColumnName("Name");
            builder.Property(p => p.Surname).HasColumnName("Surname");
            builder.Property(p => p.DateBirth).HasColumnName("DateBirth");
            builder.Property(p => p.CPF).HasColumnName("CPF");
            builder.Property(p => p.Email).HasColumnName("Email");
            builder.Property(p => p.Country).HasColumnName("Country");
            builder.Property(p => p.State).HasColumnName("State");
            builder.Property(p => p.City).HasColumnName("City");
            builder.Property(p => p.CEP).HasColumnName("CEP");
            builder.Property(p => p.Neighborhood).HasColumnName("Neighborhood");
            builder.Property(p => p.Street).HasColumnName("Street");
            builder.Property(p => p.Number).HasColumnName("Number");
            builder.Property(p => p.Complement).HasColumnName("Complement");
        }
    }
}