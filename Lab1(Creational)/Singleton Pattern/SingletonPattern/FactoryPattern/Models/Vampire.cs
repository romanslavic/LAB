namespace FactoryPattern.Models;

public class Vampire : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Vampire attacked!");
    }
}