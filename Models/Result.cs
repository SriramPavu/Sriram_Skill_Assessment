namespace IngredientApi.Models
{
    public class Result
    {
        public int TotalPeopleFed { get; set; }
        public List<AvailableIngrediants> RemainingIngredients { get; set; }
    }
}
