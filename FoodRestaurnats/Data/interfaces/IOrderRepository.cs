using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
