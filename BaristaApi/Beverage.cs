using System;
using System.Collections.Generic;
using System.Linq;

public interface IEspressoMachine
{
    public IEspressoMachine AddWater(int amount);
    public IEspressoMachine AddBeans(Beans bean);
    public IEspressoMachine AddMilk(int amount);
    public IEspressoMachine AddChocolateSyrup(int amount);
    public IEspressoMachine AddMilkFoam(int amount);
    public IEspressoMachine Validate(Func<EspressoMachine, bool> validate);
    public Beverage ToBeverage();
}

public class EspressoMachine : IEspressoMachine
{
    public List<Ingredient> Ingredients { get; } = new List<Ingredient>();

    public int Temperature = 90;

    public IEspressoMachine AddWater(int amount)
    {
        Ingredients.Add(new Water
        {
            Amount = amount
        });

        return this;
    }

    public IEspressoMachine Validate(Func<EspressoMachine, bool> validate)
    {
        if(validate.Invoke(this))
        {
            return this;
        }
        else
        {
            throw new Exception("Service needed");
        }
    }

    public IEspressoMachine AddBeans(Beans beans)
    {
        Ingredients.Add(beans);

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
        var ingredientSorted = this.Ingredients.Select(ingredient => ingredient.Name).OrderBy(ingredient => ingredient);

        if (ingredientSorted.SequenceEqual(Espresso.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Espresso();
        }
        else if (ingredientSorted.SequenceEqual(Cappuccino.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Cappuccino();
        }
        else if (ingredientSorted.SequenceEqual(Americano.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Americano();
        }
        else if (ingredientSorted.SequenceEqual(Macchiato.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Macchiato();
        }
        else if (ingredientSorted.SequenceEqual(Cappuccino.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Cappuccino();
        }
        else if (ingredientSorted.SequenceEqual(Mocha.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Mocha();
        }
        else if (ingredientSorted.SequenceEqual(Latte.Ingredients.OrderBy(ingredient => ingredient)))
        {
            return new Latte();
        }

        // No match, return null OR a custom beverage?
        return new Custom(ingredientSorted.ToList());
    }
}

// TODO: Remove this or replace the abstract class "Beverage" with this interface?
public interface IBeverage
{
    string Name { get; set; }
    List<Ingredient> Ingredients { get; }
    string CupType { get; }

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

    public Custom(List<string> ingredients)
    {
        this.Ingredients = ingredients;
    }
}

public enum CoffeSorts
{
    Robusta,
    Arabica
}

public class Ingredient 
{
    public virtual string Name { get; set; }
    public int Amount { get; set; }
}

public class Water : Ingredient
{
    public override string Name { get; set; } = "Water";
    public int Temperature { get; set; }
}

public class Beans : Ingredient
{
    public override string Name { get; set; } = "Beans";
    public CoffeSorts Sort { get; set; }
}
