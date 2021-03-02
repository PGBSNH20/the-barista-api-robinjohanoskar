using System.Collections.Generic;

public interface IBeverage
{
    //private List<Ingredient> Ingredients => _ingredient;
    string Name { get; set; }
    List<Ingredient> Ingredients { get; }
    string CupType { get; }

    IBeverage AddWater(int amount);
    IBeverage AddBeans(int amount);
    IBeverage AddMilk(int amount);
}


//enum CoffeSorts
//{
//    Robusta
//}

//public interface IIngredient
//{

//}

//class Bean : IIngredient
//{ 

//}

public class Ingredient
{
    public string Name { get; set; }
    public int Amount { get; set; }
}

class Espresso : IBeverage
{
    //private List<Ingredient> Ingredients { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients => throw new System.NotImplementedException();
    public string CupType { get; set; }

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });

        Water water = new Water()
        {
            Amount = 2,
            Temperature = 90
        };
        
        return this;
    }

    public IBeverage AddBeans(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Bean",
            Amount = amount
        });


        return this;
    }

    public IBeverage AddMilk(int amount)
    {
        return this;
    }

}
class Cappucino : IBeverage
{
    //private List<Ingredient> Ingredients { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients => throw new System.NotImplementedException();
    public string CupType { get; set; }

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });

        Water water = new Water()
        {
            Amount = 2,
            Temperature = 90
        };
        
        return this;
    }

    public IBeverage AddBeans(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Bean",
            Amount = amount
        });


        return this;
    }

    public IBeverage AddMilk(int amount)
    {
        return this;
    }
}
class Americano : IBeverage
{
    //private List<Ingredient> Ingredients { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients => throw new System.NotImplementedException();
    public string CupType { get; set; }

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });

        Water water = new Water()
        {
            Amount = 2,
            Temperature = 90
        };
        
        return this;
    }

    public IBeverage AddBeans(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Bean",
            Amount = amount
        });


        return this;
    }

    public IBeverage AddMilk(int amount)
    {
        return this;
    }
}
class Macchiato : IBeverage
{
    //private List<Ingredient> Ingredients { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients => throw new System.NotImplementedException();
    public string CupType { get; set; }

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });

        Water water = new Water()
        {
            Amount = 2,
            Temperature = 90
        };

        return this;
    }

    public IBeverage AddBeans(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Bean",
            Amount = amount
        });


        return this;
    }

    public IBeverage AddMilk(int amount)
    {
        return this;
    }
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

