using AbstractFactoryPattern.Models.Vampire;
using AbstractFactoryPattern.Models.Werewolf;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories;

public class HighLevelEnemyFactory : IEnemyFactory
{
    public IVampire CreateVampire()
    {
        return new HighLevelVampire();
    }

    public IWerewolf CreateWerewolf()
    {
        return new HighLevelWerewolf();
    }
}