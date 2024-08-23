using Assignment3EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3EntityFrameworkCore.Configurations
{
    public class DepartmentsConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);
            D.Property(d => d.Id).UseIdentityColumn(10, 10);
            D.Property(d => d.Name).IsRequired(true).HasMaxLength(20);
        }
    }
}
