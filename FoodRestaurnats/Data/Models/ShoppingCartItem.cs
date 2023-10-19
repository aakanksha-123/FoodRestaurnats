using System.ComponentModel.DataAnnotations.Schema;

namespace FoodRestaurnats.Data.Models
{
    public class ShoppingCartItem
    {

        public int ShoppingCartItemId { get; set; }

        [ForeignKey("foodId")]
        public food? food { get; set; }

        public int foodId { get; set; } //added

        public int Amount { get; set; }

        public string? ShoppingCartId { get; set; }
    }
}
