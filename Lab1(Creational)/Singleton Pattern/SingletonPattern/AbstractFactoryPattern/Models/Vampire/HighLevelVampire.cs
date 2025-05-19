using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Models.Vampire;

public class HighLevelVampire : IVampire
{
    public void Attack()
    {
        Console.WriteLine("Vampire attacks for 50 damage");
    }

    public void Defend()
    {
        Console.WriteLine("Vampire defends 50 damage");
    }

    public void DrinkBlood()
    {
        Console.WriteLine("Vampire drinks blood for 50 damage");
    }
}