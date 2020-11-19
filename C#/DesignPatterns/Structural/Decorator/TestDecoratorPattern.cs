using System;

namespace Decorator
{
    public static class TestDecoratorPattern
    {
        public static void Main(string[] args)
        {
            IPizza simpleVegpizza = new SimplyVegPizza();
            simpleVegpizza.Price = 230.00m;
            simpleVegpizza.Description = "SimplyVegPizza";
            
            IPizza romaTomatoes = new RomaTomatoes(simpleVegpizza);
            romaTomatoes.Price = 5.20m;
            romaTomatoes.Description = "Roma Tomatoes";
            
            IPizza greenOlives = new GreenOlives(simpleVegpizza);
            greenOlives.Price = 5.47m;
            greenOlives.Description = "Green Olives";
            
            IPizza spinach = new Spinach(simpleVegpizza);
            spinach.Price = 7.92m;
            spinach.Description = "Spinach";
            
            Console.WriteLine($"Desc: {simpleVegpizza.Description} ({simpleVegpizza.Price}), {romaTomatoes.Description} ({romaTomatoes.Price}), {greenOlives.Description} ({greenOlives.Price}), {spinach.Description} ({spinach.Price})");
            Console.WriteLine($"Price: {(simpleVegpizza.Price + romaTomatoes.Price + greenOlives.Price + spinach.Price)}");

            IPizza simplyNonVeg = new SimplyNonVegPizza();
            simplyNonVeg.Price = 350m;
            simplyNonVeg.Description = "SimplyNonVegPizza";

            IPizza meat = new Meat(simplyNonVeg);
            meat.Price = 14.25m;
            meat.Description = "Meat";

            IPizza cheese = new Cheese(simplyNonVeg);
            cheese.Price = 20.72m;
            cheese.Description = "Cheese";

            IPizza ham = new Ham(simplyNonVeg);
            ham.Price = 18.12m;
            ham.Description = "Ham";

            Console.WriteLine($"Desc: {simplyNonVeg.Description} ({simplyNonVeg.Price}), {meat.Description} ({meat.Price}), {cheese.Description} ({cheese.Price}), {cheese.Description} ({cheese.Price}), {ham.Description} ({ham.Price})");
            Console.WriteLine($"Price: {(simplyNonVeg.Price + meat.Price + cheese.Price + cheese.Price + ham.Price)}");
            
        }
    }
}