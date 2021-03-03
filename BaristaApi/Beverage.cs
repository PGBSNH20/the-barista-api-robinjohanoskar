using System.Collections.Generic;

interface IEspressoMachine
{
    IEspressoMachine AddWater(int amount);
    IEspressoMachine AddBeans(int amount);
    IEspressoMachine AddMilk(int amount);
    IEspressoMachine AddChocolateSyrup(int amount);
    IEspressoMachine AddMilkFoam(int amount);
    Beverage ToBeverage();

}

class EspressoMachine : IEspressoMachine
{
    List<Ingredient> Ingredients { get; }


    //Dictionary<string, List<string>> CoffeeTypes =
    //    new Dictionary<string, List<string>>()
    //    {
    //        { "Cappuccino", new List<string>
    //        {
    //            "Milk foam",
    //            "Milk",
    //            "Espresso"
    //        }

    //        },


    //    };




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

    public IEspressoMachine AddMilk(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Milk",
            Amount = amount
        });


        return this;
    }
    public IEspressoMachine AddChocolateSyrup(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Chocolate Syrup",
            Amount = amount
        });

        return this;
    }
    public IEspressoMachine AddMilkFoam(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Milk Foam",
            Amount = amount
        });

        return this;
    }

    public Beverage ToBeverage()
    {
        return new Espresso();

        if (Espresso.Ingredients == )
        {
            return new Espresso();
        }
        else if ("has milk")
        {
            return new Latte();
        }

        if (this.DrinkName == "Espresso")
        {
            return new Espresso();
        }

        //class Cappucino : Beverage { }
        //class Americano : Beverage { }
        //class Espresso : Beverage { }
        //class Macchiato : Beverage { }
        //class Mocha : Beverage { }
        //class Latte : Beverage { }
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

class Cappuccino : Beverage 
{
    public static List<string> Ingredients = new List<string> 
    {
        "Milk Foam",
        "Milk",
        "Water",
        "Beans"
    };              
}
class Americano : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Water",
        "Beans"
    };
}
class Espresso : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans"
    };
}
class Macchiato : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans",
        "Milk Foam"
    };
}
class Mocha : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans",
        "Chocolate Syrup",
        "Milk"
    };
}
class Latte : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans",
        "Milk"
    };
}

public enum DrinkType
{
    Espresso,
    Arabica
}

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

