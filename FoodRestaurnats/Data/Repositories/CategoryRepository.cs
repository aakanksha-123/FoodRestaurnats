using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }




        public IEnumerable<category> Categories => _appDbContext.Categories;
    }
}


