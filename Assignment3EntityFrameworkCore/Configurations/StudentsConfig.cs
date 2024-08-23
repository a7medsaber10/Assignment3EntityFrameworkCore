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
    public class StudentsConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(s => s.Id);
            S.Property(s => s.Id).UseIdentityColumn();
            S.Property(s => s.FName).IsRequired(true).HasColumnType("varchar").HasMaxLength(50);
            S.Property(s => s.LName).IsRequired(true).HasColumnType("varchar").HasMaxLength(50);
            S.Property(s => s.Address).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
