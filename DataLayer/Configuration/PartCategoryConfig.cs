using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class PartCategoryConfig : IEntityTypeConfiguration<PartCategory>
    {
        public void Configure(EntityTypeBuilder<PartCategory> entity)
        {
            entity.HasKey(e => e.PartCategoryID);                    
        }
    }
}