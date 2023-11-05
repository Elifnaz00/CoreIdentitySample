using CoreIdentitySample.Models.Enums;
using CoreIdentitySample.Models.Interfaces;

namespace CoreIdentitySample.Models.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity() 
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
