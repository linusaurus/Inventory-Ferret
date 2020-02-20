using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class AssemblyConfig : IEntityTypeConfiguration<Assembly>
    {
        public void Configure(EntityTypeBuilder<Assembly> entity)
        {
            entity.HasKey(p => p.AssemblyId);

            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");

            entity.Property(e => e.ArchRef).HasMaxLength(120);

            entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.AssemblyName).HasMaxLength(120);

            entity.Property(e => e.CalculatedCost).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Depth).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.LaborHours).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.Note)
                .HasMaxLength(120)
                .HasDefaultValueSql("(' ')");

            entity.Property(e => e.Perimeter).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.ProductionDate).HasColumnType("date");

            entity.Property(e => e.ProductionGroupId).HasColumnName("ProductionGroupID");

            entity.Property(e => e.ProductionId)
                .IsRequired()
                .HasColumnName("ProductionID")
                .HasMaxLength(50);

            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductionGroup)
                .WithMany(p => p.Assembly)
                .HasForeignKey(d => d.ProductionGroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Article_Project");
        }
    }
}