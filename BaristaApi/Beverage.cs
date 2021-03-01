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

class Espresso : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}

class Latte : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}

