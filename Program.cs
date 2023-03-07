using System;
using System.Collections.Generic;


public abstract class Candy
{
    protected string Name { get; }
    public int Weight { get; }

    protected Candy(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }

    public abstract string GetDescription();
}

public class Chocolate : Candy
{
    private string Type { get; }

    public Chocolate(string name, int weight, string type):base(name, weight)
    {
        Type = type;
    }

    public override string GetDescription()
    {
        return $"A {Weight}g {Type} chocolate bar";
    }
}

public class GummyBear : Candy
{
    private string Flavor { get; }

    public GummyBear(string name, int weight, string flavor):base(name, weight)
    {
        Flavor = flavor;
    }

    public override string GetDescription()
    {
        return $"A {Weight}g bag of {Flavor} gummy bears";
    }
}

public class Lollipop : Candy
{
    private string Color { get; }

    public Lollipop(string name, int weight, string color): base(name, weight)
    {
        Color = color;
    }

    public override string GetDescription()
    {
        return $"A {Weight}g {Color} lollipop";
    }
}


public class Marmalade : Candy
{
    private string Taste { get; }

    public Marmalade(string name, int weight, string taste) : base(name, weight)
    {
        Taste = taste;
    }

    public override string GetDescription()
    {
        return $"A {Weight}g {Taste} marmalade";
    }
}


  public class Cooki: Candy
{
    private string Taste { get; }

    public Cooki(string name,int weight, string taste): base (name, weight)
    {
        Taste = taste;
    }

    public override string GetDescription()
    {
        return $"A {Weight}g {Taste} cooki";
    }

}
public class ChildrensGift
{
    private List<Candy> candies = new List<Candy>();

    public void AddCandy(Candy candy)
    {
        candies.Add(candy);
    }

    public int GetTotalWeight()
    {
        int totalWeight = 0;
        foreach (Candy candy in candies)
        {
            totalWeight += candy.Weight;
        }
        return totalWeight;
    }

    public void PrintContents()
    {
        Console.WriteLine($"The children's gift contains {candies.Count} candies:");
        foreach (Candy candy in candies)
        {
            Console.WriteLine($"- {candy.GetDescription()}");
        }
        Console.WriteLine($"Total weight: {GetTotalWeight()}g");
    }
}

public class Program
{
    public static void Main()
    {
        ChildrensGift gift = new ChildrensGift();
        gift.AddCandy(new Chocolate("Mars", 50, "milk"));
        gift.AddCandy(new GummyBear("Haribo Goldbears", 100, "fruit"));
        gift.AddCandy(new Lollipop("Chupa Chups", 20, "red"));
        gift.AddCandy(new Marmalade("Bubble pop", 100, "fruits"));
        gift.AddCandy(new Cooki("Grandio", 250, "chocolate"));
        gift.PrintContents();
    }
}