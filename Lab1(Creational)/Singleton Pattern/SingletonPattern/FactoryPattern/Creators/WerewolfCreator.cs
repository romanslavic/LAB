using FactoryPattern.Models;

namespace FactoryPattern.Creators;

public class WerewolfCreator : EnemyCreator
{
    public override IEnemy CreateEnemy()
    {
        return new Werewolf();
    }
}