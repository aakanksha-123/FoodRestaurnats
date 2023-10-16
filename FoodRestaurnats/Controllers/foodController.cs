using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;
using FoodRestaurnats.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodRestaurnats.Controllers
{
    public class foodController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IfoodRepository _foodRepository;


        public foodController(ICategoryRepository categoryRepository, IfoodRepository foodRepository)
        {
            _categoryRepository = categoryRepository;
            _foodRepository = foodRepository;
        }
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<food> foods;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                foods = _foodRepository.foods.OrderBy(n => n.foodId);
                currentCategory = "All food";
            }
            else
            {
                if (string.Equals("Veg", _category, StringComparison.OrdinalIgnoreCase))
                    foods = _foodRepository.foods.Where(p => p.Category.CategoryName.Equals("Veg")).OrderBy(p => p.Name);
                else
                    foods = _foodRepository.foods.Where(p => p.Category.CategoryName.Equals("Non-Veg")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new foodListViewModel
            {
                foods = foods,
                CurrentCategory = currentCategory
            });

        }

    }


}

            //ViewBag.Name = "DotNet,How?";


            ////var food = _foodRepository.foods;
            //foodListViewModel vm = new foodListViewModel();
            //vm.foods = _foodRepository.foods;
            //vm.CurrentCategory = "foodCategory";
            ////var foods = _foodRepository.foods;
            //return View(vm);
