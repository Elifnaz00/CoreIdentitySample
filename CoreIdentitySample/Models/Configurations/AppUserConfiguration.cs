using CoreIdentitySample.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreIdentitySample.Models.Configurations
{
    public class AppUserConfiguration:BaseConfigration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID); //Zaten Identity class ında Id geleceği için buradaki ID yi ignore ettik
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID);
            builder.HasMany(x => x.Orders).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserID);
            builder.HasMany(x => x.UserRoles).WithOne(x => x.User).HasForeignKey(x => x.UserId).IsRequired(); ;

        }

    }
}
