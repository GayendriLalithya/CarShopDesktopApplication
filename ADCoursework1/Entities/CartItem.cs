using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class CartItem
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
