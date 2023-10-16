using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<category> Categories { get; }
        
    }
}
