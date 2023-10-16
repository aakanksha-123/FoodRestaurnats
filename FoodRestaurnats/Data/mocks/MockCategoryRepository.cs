using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<category> Categories
        {
            get
            {
                return new List<category>
                {
                    new category { CategoryName = "Veg", Description = "All veg dishes" },
                    new category { CategoryName = "Non-Veg", Description = "All non-veg dishes" }
                };
            }
        }

        //public object foods => throw new NotImplementedException();
    }
}
