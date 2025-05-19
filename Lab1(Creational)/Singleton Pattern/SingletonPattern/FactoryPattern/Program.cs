using FactoryPattern.Creators;
using FactoryPattern.Models;

EnemyCreator enemyCreator = new WerewolfCreator();


IEnemy enemy = enemyCreator.CreateEnemy();
enemy.Attack();
enemy.Attack();
enemy.Attack();
