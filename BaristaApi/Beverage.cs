using System.Collections.Generic;

/*---------------------------- Efter 2021-03-03: ----------------------------*/
public interface IMilk
{
    IMilk AddMilk(int amount);
}

public interface ICoffeeSyrup
{
    ICoffeeSyrup AddCoffeeSyrup(int amount);
}

interface IEspressoMachine
{
    IEspressoMachine AddWater(int amount);
    IEspressoMachine AddBeans(int amount);
    Beverage ToBeverage();
}

class EspressoMachine : IEspressoMachine
{
    List<Ingredient> Ingredients { get; }

    public IEspressoMachine AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });

        return this;
    }

    public IEspressoMachine AddBeans(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Bean",
            Amount = amount
        });


        return this;
    }

    public Beverage ToBeverage()
    {
        return new Espresso();
    }
}


public interface IBeverage
{
    //private List<Ingredient> Ingredients => _ingredient;
    string Name { get; set; }
    List<Ingredient> Ingredients { get; }
    string CupType { get; }

}

public class Ingredient
{
    public string Name { get; set; }
    public int Amount { get; set; }
}


abstract class Beverage
{
    string Name { get; set; }
    List<Ingredient> Ingredients { get; }
    string CupType { get; }
}

class Cappucino : Beverage { }
class Americano : Beverage { }
class Espresso : Beverage { }
class Macchiato : Beverage { }
class Mocha : Beverage { }
class Latte : Beverage { }


public enum BeanType
{
    Robusta,
    Arabica
}

public enum Ingredients
{
    Milk,
    MilkFoam,
    ChocolateSyrup
}

class Water
{
    public int Amount { get; set; }
    public int Temperature { get; set; }
}

class Beans
{
    public int Amount { get; set; }
    public BeanType Sort { get; set; }
}

