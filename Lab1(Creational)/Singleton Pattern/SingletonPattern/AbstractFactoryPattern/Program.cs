using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Products;

IEnemyFactory lowLevelEnemyFactory = new LowLevelEnemyFactory();
IEnemyFactory highLevelEnemyFactory = new HighLevelEnemyFactory();

IVampire lowLevelVampire = lowLevelEnemyFactory.CreateVampire();
IWerewolf highLevelWerewolf = highLevelEnemyFactory.CreateWerewolf();

lowLevelVampire.Attack();
lowLevelVampire.DrinkBlood();
highLevelWerewolf.Attack();
highLevelWerewolf.Transform();