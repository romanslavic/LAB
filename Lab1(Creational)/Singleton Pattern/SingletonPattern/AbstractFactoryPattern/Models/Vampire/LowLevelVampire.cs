using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Models.Vampire;

public class LowLevelVampire : IVampire
{
    public void Attack()
    {
        Console.WriteLine("Vampire attacks for 10 damage");
    }

    public void Defend()
    {
        Console.WriteLine("Vampire defend 10 damage");
    }

    public void DrinkBlood()
    {
        Console.WriteLine("Vampire drinks blood for 10 damage");
    }
}