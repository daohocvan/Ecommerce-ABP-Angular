using Volo.Abp.Domain.Entities;

namespace Ecommerce.Products
{
    public class Tag : Entity<string>
    {
        public string Label { get; set; }
    }
}