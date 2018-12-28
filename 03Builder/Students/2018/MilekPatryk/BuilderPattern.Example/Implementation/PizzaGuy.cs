using System;
using BuilderPattern.Example.Models;

namespace BuilderPattern.Example.Implementation
{
    public class PizzaGuy : IDisposable
    {
        public PizzaGuy()
        {
            Pizza = new Pizza();
        }

        private Pizza Pizza { get; set; }

        public Pizza MakePizza()
        {
            return Pizza;
        }

        public PizzaGuy AddCheese()
        {
            Pizza.Ingredients.Add("Cheese");
            return this;
        }

        public PizzaGuy AddHam()
        {
            Pizza.Ingredients.Add("Ham");
            return this;
        }

        public PizzaGuy AddMushrooms()
        {
            Pizza.Ingredients.Add("Mushrooms");
            return this;
        }

        public PizzaGuy AddKebab()
        {
            Pizza.Ingredients.Add("Kebab");
            return this;
        }

        public PizzaGuy AddPeperoni()
        {
            Pizza.Ingredients.Add("Peperoni");
            return this;
        }

        public PizzaGuy AddPineapple()
        {
            Pizza.Ingredients.Add("Pineapple");
            return this;
        }

        public void Dispose()
        {
            Pizza = null;
        }
    }
}