using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public interface IEspressoMachine
{
    public IEspressoMachine AddWater(int amount);
    public IEspressoMachine AddBeans(Beans bean);
    public IEspressoMachine AddMilk(int amount);
    public IEspressoMachine AddChocolateSyrup(int amount);
    public IEspressoMachine AddMilkFoam(int amount);
    //IEspressoMachine Heater(int toHeat);

    public Beverage ToBeverage();
}

public class EspressoMachine : IEspressoMachine
{
    public Water water { get; set; }
    public Beans beans { get; set; }

    List<Ingredient> Ingredients { get; } = new List<Ingredient>();

    public IEspressoMachine AddWater(int amount)
    {
        if (water == null)
        {
            water = new Water
            {
                Temperature = 10,
                Amount = amount
            };
        }
        else
        {
            Ingredients.Add(new Ingredient()
            {
                Name = "Water",
                Amount = amount
            });
        }
        return this;
    }

    public IEspressoMachine AddBeans(Beans bean)
    {
        beans = bean;
        
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
        // Get an alphabetically sorted array of the ingredients.
        var ingredientSorted = this.Ingredients.Select(ingredient => ingredient.Name).ToList();
        ingredientSorted.Add("Water");
        ingredientSorted.Add("Beans");
        ingredientSorted = ingredientSorted.OrderBy(abc => abc).ToList();

        // Loop through each coffee Type (class).
        foreach (var beverageClassName in Beverages.List)
        {
            // Get the static field (a list of ingredients) from the class.
            var a = beverageClassName.GetField("Ingredients", BindingFlags.Public | BindingFlags.Static);
            // Get the value from the field (the list of ingredients).
            var b = (List<string>)a.GetValue(null);
            // If the ingredients of the coffee Type (class) matches the ingredients added to the EspressoMachine ...
            if (ingredientSorted.SequenceEqual(b.OrderBy(abc => abc)))
            {
                // ... return a new instance of the correct coffee Type (class).
                Console.WriteLine($"Your {beverageClassName.Name} is ready. Enjoy!");
                return (dynamic)Activator.CreateInstance(beverageClassName);
            }
        }

        // No match, return a custom beverage.
        Console.WriteLine($"Your coffee is ready. Enjoy!");
        return new Custom(ingredientSorted.ToList());
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


public abstract class Beverage
{
    string Name { get; set; }
    List<Ingredient> Ingredients { get; }
    string CupType { get; }
}

public class Cappuccino : Beverage 
{
    public static List<string> Ingredients = new List<string> 
    {
        "Milk Foam",
        "Milk",
        "Water",
        "Beans"
    };              
}
public class Americano : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Water",
        "Beans"
    };
}
public class Espresso : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans"
    };
}
public class Macchiato : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans",
        "Milk Foam"
    };
}
public class Mocha : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans",
        "Chocolate Syrup",
        "Milk"
    };
}
public class Latte : Beverage 
{
    public static List<string> Ingredients = new List<string>
    {
        "Water",
        "Beans",
        "Milk"
    };
}

public class Custom : Beverage
{
    public List<string> Ingredients = new List<string>();

    public Custom(List <string> ingredients)
    {
        this.Ingredients = ingredients;
    }
}

public static class Beverages
{
    public static List<Type> List { get; set; } = new List<Type>
    {
        typeof(Cappuccino),
        typeof(Americano),
        typeof(Espresso),
        typeof(Macchiato),
        typeof(Mocha),
        typeof(Latte),
    };
}

public enum DrinkType
{
    Espresso,
    Arabica
}

public enum CoffeSorts
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

public class Water
{
    public int Amount { get; set; }
    public int Temperature { get; set; }
}

public class Beans
{
    public int Amount { get; set; }
    public CoffeSorts Sort { get; set; }
}

