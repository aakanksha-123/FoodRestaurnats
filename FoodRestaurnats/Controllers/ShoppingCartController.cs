using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;
using FoodRestaurnats.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodRestaurnats.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IfoodRepository _foodRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly List<ShoppingCartItem>? items;

        public ShoppingCartController(IfoodRepository foodRepository, ShoppingCart shoppingCart)
        {
            _foodRepository = foodRepository;
            _shoppingCart = shoppingCart;

        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var scvm = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return View(scvm);
        }
        public RedirectToActionResult AddToShoppingCart(int foodId)
        {
            var Selectedfood = _foodRepository.foods.FirstOrDefault(p => p.foodId == foodId);
            if (Selectedfood != null)
            {
                _shoppingCart.AddToCart(Selectedfood, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int foodId)
        {
            var selectedfood = _foodRepository.foods.FirstOrDefault(p => p.foodId == foodId);
            if (selectedfood != null)
            {

                _shoppingCart.RemoveFromCart(selectedfood);

            }
            return RedirectToAction("Index");

        }
    }
}
