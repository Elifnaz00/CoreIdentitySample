using CoreIdentitySample.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreIdentitySample.Models.Configurations
{
    public class AppUserProfileConfiguration:BaseConfigration<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);

        }
    }
}
