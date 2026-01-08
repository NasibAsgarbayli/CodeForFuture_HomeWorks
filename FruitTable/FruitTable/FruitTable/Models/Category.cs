using System.ComponentModel.DataAnnotations;

namespace FruitTables.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
