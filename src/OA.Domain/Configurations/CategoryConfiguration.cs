using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OA.Domain.Entities;

namespace OA.Domain.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CategoryName).HasMaxLength(250);
            builder.Property(x => x.CreationDate).HasColumnType("datetime2(7)");
        }
    }
}
