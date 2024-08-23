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
    public class TopicsConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
            T.HasKey(T => T.Id);
            T.Property(T => T.Id).UseIdentityColumn();
            T.Property(T => T.Name).IsRequired(true).HasMaxLength(20);
        }
    }
}
