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
    public class InstructorsConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Id).UseIdentityColumn(1, 1);
            I.Property(I => I.Name).IsRequired(true).HasMaxLength(20);
            I.Property(I => I.Salary).IsRequired(true).HasColumnType("money");
            I.Property(I => I.Bonus).HasColumnType("money");
            I.Property(I => I.Address).HasMaxLength(50);
        }
    }
}
