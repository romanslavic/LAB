using FactoryPattern.Models;

namespace FactoryPattern.Creators;

public abstract class EnemyCreator
{
    public abstract IEnemy CreateEnemy();

}