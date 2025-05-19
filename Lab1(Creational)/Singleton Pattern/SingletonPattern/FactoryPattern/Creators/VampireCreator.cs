using FactoryPattern.Models;

namespace FactoryPattern.Creators;

public class VampireCreator : EnemyCreator
{
    public override IEnemy CreateEnemy()
    {
        return new Vampire();
    }
}