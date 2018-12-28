using System;
using BuilderPattern.Example.Implementation;
using BuilderPattern.Example.Models;

namespace BuilderPattern.Example
{
    internal class Program
    {
        internal static void Main()
        {
            // Builder
            Pizza pizza;
            using (var pizzaGuy = new PizzaGuy())
            {
                pizza = pizzaGuy.AddCheese()
                    .AddHam()
                    .AddMushrooms()
                    .AddPineapple()
                    .MakePizza();
            }
            Console.WriteLine(pizza);

            using (var pizzaGuy = new PizzaGuy())
            {
                pizza = pizzaGuy.AddCheese()
                    .AddKebab()
                    .AddPeperoni()
                    .MakePizza();
            }
            Console.WriteLine(pizza);

            // Factory
            var connection = ConnectionFactory.CreateMSSQLConnection();
            Console.WriteLine(connection);

            connection = ConnectionFactory.CreateAzureSQLConnection();
            Console.WriteLine(connection);

            connection = ConnectionFactory.CreatePostgreSqlConnection();
            Console.WriteLine(connection);
        }
    }
}
