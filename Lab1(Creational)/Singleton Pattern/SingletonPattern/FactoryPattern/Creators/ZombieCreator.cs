using FactoryPattern.Models;

namespace FactoryPattern.Creators;

public class ZombieCreator : EnemyCreator
{
    public override IEnemy CreateEnemy()
    {
        return new Zombie();
    }
}