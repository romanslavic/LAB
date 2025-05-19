using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Models.Werewolf;

public class HighLevelWerewolf : IWerewolf
{
    public void Attack()
    {
        Console.WriteLine("Werewolf attacks for 50 damage");
    }

    public void Defend()
    {
        Console.WriteLine("Werewolf defends 50 damage");
    }

    public void Transform()
    {
        Console.WriteLine("Werewolf transforms and defends 50 damage");
    }
}