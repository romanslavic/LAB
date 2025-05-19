namespace FactoryPattern.Models;

public class Zombie : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Zombie attacked!");
    }
}