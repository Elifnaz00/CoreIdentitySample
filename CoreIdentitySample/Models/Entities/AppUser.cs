using CoreIdentitySample.Models.Enums;
using CoreIdentitySample.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreIdentitySample.Models.Entities
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser() 
        { 
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }

        public virtual List<AppUserRole> UserRoles { get; set; }
    }
}
