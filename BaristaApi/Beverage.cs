using System.Collections.Generic;

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

public interface IBeverage {
    //private List<Ingredient> Ingredients => _ingredient;
    List<Ingredient> Ingredients { get; }
    string CupType { get; }

    IBeverage AddWater(int amount);
    IBeverage AddBeans(int amount);
    IBeverage AddMilk(int amount);
}

public class Ingredient
{
    public string Name { get; set; }
    public int Amount { get; set; }
}

class Espresso : IBeverage
{
    //private List<Ingredient> Ingredients { get; set; }
    public List<Ingredient> Ingredients => throw new System.NotImplementedException();

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });
        
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

    public string CupType => throw new System.NotImplementedException();
}

//class Latte : IBeverage
//{
//    public List<string> Ingredients => throw new System.NotImplementedException();
    
//    public IBeverage AddWater()
//    {
//        // context method
        
//        return this;
//    }
//    public IBeverage AddBeans()
//    {
//        // context method
        
//        return this;
//    }

//    public string CupType => throw new System.NotImplementedException();
//}

