namespace IngredientApi.Models
{
    public class Ingrediate
    {
        public Result Calculate()
        {
            var availableIngredients = new Dictionary<string, int>
            {
                { "Cucumber", 2 },
                { "Olives", 2 },
                { "Lettuce", 3 },
                { "Meat", 6 },
                { "Tomato", 6 },
                { "Cheese", 8 },
                { "Dough", 10 }
            };

            var recipes = new List<Recipe>
            {
                new Recipe
                {
                    Name = "Pizza",
                    Ingredients = new Dictionary<string, int>
                    {
                        { "Dough", 6 },
                        { "Tomato", 4 },
                        { "Cheese", 6 },
                        { "Olives", 2 }
                    },
                    People = 8
                },
                new Recipe
                {
                    Name = "Sandwich",
                    Ingredients = new Dictionary<string, int>
                    {
                        { "Dough", 2 },
                        { "Cucumber", 4 }
                    },
                    People = 2
                },
                new Recipe
                {
                    Name = "Pasta",
                    Ingredients = new Dictionary<string, int>
                    {
                        { "Dough", 2 },
                        { "Tomato", 1 },
                        { "Cheese", 2 },
                        { "Meat", 1 }
                    },
                    People = 2
                }
            };

            foreach (var recipe in recipes)
            {
                foreach (var item in recipe.Ingredients)
                {
                    if (availableIngredients.ContainsKey(item.Key))
                    {
                        availableIngredients[item.Key] -= item.Value;
                    }
                }
            }

            var result = new Result
            {
                TotalPeopleFed = recipes.Sum(r => r.People),
                RemainingIngredients = availableIngredients
                    .Select(i => new AvailableIngrediants { Name = i.Key, Quantity = i.Value })
                    .ToList()
            };

            return result;
        }
    }
}

