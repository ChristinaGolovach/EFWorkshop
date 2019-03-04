using System.Collections.Generic;

namespace DAL.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //For step 2
        //public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
