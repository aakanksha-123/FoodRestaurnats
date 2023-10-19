using FoodRestaurnats.Data;
using FoodRestaurnats.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FoodRestaurnats.Controllers
{
    public class OrderDetailsController : Controller
    {

        private readonly AppDbContext _context;

        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Status( )
        {
            var orders = _context.OrderDetails.ToList();
            return View(orders);
        }
        
    }
}
