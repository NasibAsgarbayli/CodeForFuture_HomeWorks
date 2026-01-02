using System.Collections.Generic;

namespace fruitables_1_0_0.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}