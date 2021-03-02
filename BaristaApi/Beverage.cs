using System.Collections.Generic;

enum CoffeSorts
{
    Robusta
}

public interface IIngredient
{

}

class Bean : IIngredient
{ 

}

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
    void AddMilk(int amount);
    void AddWater(int amount);
    void AddBeans(int amount);
}

class Ingredient
{
    public string Name { get; set; }
    public int Amount { get; set; }
}

class Espresso : IBeverage
{
    List<Ingredient> Ingredients = new List<Ingredient>();

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(new Ingredient()
        {
            Name = "Water",
            Amount = amount
        });
        
        return this;
    }
    public IBeverage AddBeans()
    {
        // context method
        
        return this;
    }

    public string CupType => throw new System.NotImplementedException();
}

class Latte : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();
    
    public IBeverage AddWater()
    {
        // context method
        
        return this;
    }
    public IBeverage AddBeans()
    {
        // context method
        
        return this;
    }

    public string CupType => throw new System.NotImplementedException();
}

