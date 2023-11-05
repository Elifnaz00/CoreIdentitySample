using CoreIdentitySample.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreIdentitySample.Models.Configurations
{
    public class AppUserRoleConfiguration:BaseConfigration<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.UserId,
                x.RoleId
            });
        }
    }
}
