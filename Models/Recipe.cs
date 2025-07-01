namespace IngredientApi.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }
        public int People { get; set; }
    }
}
