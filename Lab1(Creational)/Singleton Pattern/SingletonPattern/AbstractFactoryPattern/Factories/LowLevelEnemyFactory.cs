using AbstractFactoryPattern.Models.Vampire;
using AbstractFactoryPattern.Models.Werewolf;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories;

public class LowLevelEnemyFactory : IEnemyFactory
{
    public IVampire CreateVampire()
    {
        return new LowLevelVampire();
    }

    public IWerewolf CreateWerewolf()
    {
        return new LowLevelWerewolf();
    }
}