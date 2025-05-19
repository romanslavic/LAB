namespace FactoryPattern.Models;

public class Werewolf : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Werewolf attacked!");
    }
}