using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }



        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetails = new OrderDetail()
                {
                    Amount = item.Amount,
                    food = item.food,
                   foodId = item.foodId,
                    OrderId = order.OrderId,
                    Price = item.food.Price,
                    Status="Pending"

                };
                _appDbContext.OrderDetails.Add(orderDetails);
            }

            _appDbContext.SaveChanges();
        }


        //public int GetTotalById() {
        //    return _appDbContext.OrderDetail.Sum(n=>n.)

        //}
    }
}
