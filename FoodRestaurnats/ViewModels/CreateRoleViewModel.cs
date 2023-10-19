using System.ComponentModel.DataAnnotations;

namespace FoodRestaurnats.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
