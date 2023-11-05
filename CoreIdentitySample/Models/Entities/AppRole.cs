using CoreIdentitySample.Models.Enums;
using CoreIdentitySample.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreIdentitySample.Models.Entities
{
    public class AppRole : IdentityRole<int>, IEntity
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public virtual List<AppUserRole> UserRoles { get; set; }
        }
}
