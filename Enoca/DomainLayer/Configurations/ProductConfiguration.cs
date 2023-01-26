using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			//builder.Property(m => m.FirstName).IsRequired();
			//builder.Property(m => m.LastName).IsRequired();

		}
	}
}
