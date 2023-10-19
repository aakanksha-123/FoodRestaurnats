using System.ComponentModel.DataAnnotations.Schema;

namespace FoodRestaurnats.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }



        public int OrderId { get; set; }
        public int foodId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public string Status { get; set; } //property added

        //[ForeignKey("foodId")]
        public virtual food food { get; set; }

        //[ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}

