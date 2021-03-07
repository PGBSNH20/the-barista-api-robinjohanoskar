using System;
using System.Linq;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new EspressoMachine().AddBeans(new Beans {
                    Amount = 7,
                    Sort = CoffeSorts.Robusta
                })
                .AddWater(20)
                .HeatWater(92)
                .Validate(e => e.Temperature >= 92 && e.Ingredients.All(a => a.Amount > 0))
                .ToBeverage();

            Beverage latte = new EspressoMachine().AddBeans(new Beans
            {
                Amount = 12,
                Sort = CoffeSorts.Arabica
            })
                .AddWater(20)
                .AddMilk(20)
                .ToBeverage();
        }
    }
}
