using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories;

public interface IEnemyFactory
{
    IVampire CreateVampire();
    IWerewolf CreateWerewolf();
}