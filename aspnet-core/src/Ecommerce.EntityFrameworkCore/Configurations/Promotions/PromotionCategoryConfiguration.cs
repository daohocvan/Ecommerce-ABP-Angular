using Ecommerce.Promotions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Configurations.Promotions
{
    public class PromotionCategoryConfiguration : IEntityTypeConfiguration<PromotionCategory>
    {
        public void Configure(EntityTypeBuilder<PromotionCategory> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "PromotionCategories");
            builder.HasKey(x => x.Id);
        }
    }
}
