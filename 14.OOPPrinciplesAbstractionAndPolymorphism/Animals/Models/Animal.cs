using System;

namespace Animals.Models;

public abstract class Animal
{
    public string? Name { get; set; }
    public string? FavouriteFood { get; set; }

    public Animal (string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}{Environment.NewLine}";
    }
}
