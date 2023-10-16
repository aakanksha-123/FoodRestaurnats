using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodRestaurnats.Controllers
{
    public class HomeController : Controller
    {

        private readonly IfoodRepository _foodRepository;

        public HomeController(IfoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }





        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Preferredfood = _foodRepository.Preferredfood
            };
            return View(homeViewModel);
        }

    
    }
}
