using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class FirmConfiguration : IEntityTypeConfiguration<Firm>
    {
        public void Configure(EntityTypeBuilder<Firm> builder)
        {
            //builder.Property(m => m.FirstName).IsRequired();
            //builder.Property(m => m.LastName).IsRequired();

        }
    }
}
