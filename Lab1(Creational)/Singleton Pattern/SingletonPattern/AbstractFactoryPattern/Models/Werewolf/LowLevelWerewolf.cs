using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Models.Werewolf;

public class LowLevelWerewolf : IWerewolf
{
    public void Attack()
    {
        Console.WriteLine("Werewolf attacks for 10 damage");
    }

    public void Defend()
    {
        Console.WriteLine("Werewolf defends 10 damage");
    }

    public void Transform()
    {
        Console.WriteLine("Werewolf transforms and defends 10 damage");
    }
}