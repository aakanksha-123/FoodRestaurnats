using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodRestaurnats.Data.Repositories
{
    public class foodRepository : IfoodRepository


    {

        private readonly AppDbContext _appDbContext;
        public foodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }







        public IEnumerable<food> foods => _appDbContext.foods.Include(c => c.Category);

        public IEnumerable<food> Preferredfood => _appDbContext.foods.Where(p => p.IsPreferredfood)
            .Include(c => c.Category);

        public food GetfoodById(int foodId) => _appDbContext.foods.FirstOrDefault(p => p.foodId == foodId);


    }
}
