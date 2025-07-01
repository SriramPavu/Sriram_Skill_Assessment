using IngredientApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IngredientApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeoplePossibleController : Controller
    {
        private readonly Ingrediate _service;

        public PeoplePossibleController()
        {
            _service = new Ingrediate();
        }

        [HttpGet("calculate")]
        public ActionResult<string> Calculate()
        {
            var result = _service.Calculate();

            var output = $"Total number of people fed: {result.TotalPeopleFed}\n\n";
            output += "Final remaining ingredients:\n";
            foreach (var item in result.RemainingIngredients)
            {
                output += $"- {item.Name}: {item.Quantity}\n";
            }

            return Ok(output);
        }
    }
}
