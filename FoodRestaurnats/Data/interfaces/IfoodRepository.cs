using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.interfaces
{
    public interface IfoodRepository
    {
        IEnumerable<food> foods { get; }

        IEnumerable<food> Preferredfood { get; }

        food GetfoodById(int foodId);
    }
}
