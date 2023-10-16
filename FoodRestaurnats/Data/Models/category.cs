namespace FoodRestaurnats.Data.Models
{
    public class category
    {
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public string? Description { get; set; }

        public List<food>? foods { get; set; }
    }
}
