using CoreIdentitySample.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreIdentitySample.Models.Configurations
{
    public class OrderDetailConfiguration:BaseConfigration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            }
            );
        }
    }
}
