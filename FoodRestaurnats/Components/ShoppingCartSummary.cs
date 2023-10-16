using FoodRestaurnats.Data.Models;
using FoodRestaurnats.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodRestaurnats.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            /*  var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };*/ /*_shoppingCart.GetShoppingCartItems();*/

            var items =  _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }


    }
}
