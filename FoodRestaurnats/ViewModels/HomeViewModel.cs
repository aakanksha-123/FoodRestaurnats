using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<food>? Preferredfood { get; set; }
    }
}
