namespace CoreIdentitySample.Models.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }

        public int CategoryID { get; set; }

        //Relational Properties
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Category Category { get; set; }
    }
}
