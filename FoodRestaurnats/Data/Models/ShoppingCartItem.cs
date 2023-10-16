namespace FoodRestaurnats.Data.Models
{
    public class ShoppingCartItem
    {

        public int ShoppingCartItemId { get; set; }

        public food? food { get; set; }

        public int Amount { get; set; }

        public string? ShoppingCartId { get; set; }
    }
}
