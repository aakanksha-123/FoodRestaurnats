using FoodRestaurnats.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodRestaurnats.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<food> foods { get; set; }
        public DbSet<category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}

        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
