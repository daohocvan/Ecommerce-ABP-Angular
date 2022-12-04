using Ecommerce.Promotions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Configurations.Promotions
{
    public class PromotionManufacturerConfiguration : IEntityTypeConfiguration<PromotionManufacturer>
    {
        public void Configure(EntityTypeBuilder<PromotionManufacturer> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "PromotionManufacturers");
            builder.HasKey(x => x.Id);
        }
    }
}
