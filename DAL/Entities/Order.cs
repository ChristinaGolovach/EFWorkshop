using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }

        //For step 2
        //public virtual ICollection<Item> Items { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
