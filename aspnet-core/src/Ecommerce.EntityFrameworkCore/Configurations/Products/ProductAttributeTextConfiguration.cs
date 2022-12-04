using Ecommerce.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Configurations.Products
{
    public class ProductAttributeTextConfiguration : IEntityTypeConfiguration<ProductAttributeText>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeText> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeTexts");
            builder.HasKey(x => x.Id);
        }
    }
}
