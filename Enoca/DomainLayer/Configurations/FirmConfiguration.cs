using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
