using LessonOnionArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Persistence.Configurations.ProductConfiguration;
public class ProductConfig : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.Property(d => d.Title)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(d => d.Price)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(d => d.Desc)
               .HasMaxLength(500);
    }

}

