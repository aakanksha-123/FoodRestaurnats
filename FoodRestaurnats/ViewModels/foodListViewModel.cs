using FoodRestaurnats.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodRestaurnats.ViewModels
{
    public class foodListViewModel 
    {
      
          public IEnumerable<food> foods { get; set; }
        public string CurrentCategory { get; set; }
    
    }
}
