using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
             */
            // Borde vara:
            // Espresso espresso = new EspressoMachine
            // Latte latte = new FluentEspresso

            // .Validate(e => e.Temerature > 90)

            // Latte latte = new Espresso().SetDrinkType("espresso").AddWater(20).AddBeans(7, CoffeSorts.Robusta).AddMilk().Validate(e => e.Temperature > 90).ToBeravage();

            Beverage espresso = new EspressoMachine()
                                        .AddBeans(20)
                                        .AddWater(20)
                                        .ToBeverage();

            Beverage latte = new EspressoMachine()
                                        .AddBeans(20)
                                        .AddWater(20)
                                        .AddMilk(20)
                                        .ToBeverage();

        }
    }
}
