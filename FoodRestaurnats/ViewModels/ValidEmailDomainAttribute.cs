namespace FoodRestaurnats.ViewModels
{
    internal class ValidEmailDomainAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}