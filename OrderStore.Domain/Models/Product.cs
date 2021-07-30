using System.ComponentModel.DataAnnotations;

namespace OrderStore.Domain.Models
{
   public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price{ get; set; }
        public bool isDisCountApplied { get; set; }
    }
}
