namespace CoreIdentitySample.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAdreess { get; set; }

        public int AppUserID {  get; set; } 

        //Relational Properties
       
        public virtual List<OrderDetail> OrderDetails { get; set; }
        
        public virtual AppUser AppUser { get; set; }
    }
}
