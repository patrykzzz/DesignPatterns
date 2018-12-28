using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.Example.Models
{
    public class Pizza
    {
        public Pizza()
        {
            Ingredients = new List<string>();
        }

        public IList<string> Ingredients { get; set; }

        public override string ToString()
        {
            return Ingredients.Aggregate("Ingredients for the pizza are\n", (current, ingredient) => current + $"- {ingredient}\n");
        }
    }
}