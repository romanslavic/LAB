using BuilderPattern.Models;

Vampire vampire = Vampire.With()
    .Name("Red Vampire")
    .Health(150)
    .Damage(45)
    .Ability("Blood attack")
    .BloodAmount(23)
    .Build();

Werewolf werewolf = Werewolf.With()
    .Name("Werewolf")
    .Health(400)
    .Damage(25)
    .Weapon("Small Axe")
    .TransformationTime(5)
    .Build();

Console.WriteLine(
    $"{vampire.Name} - Health: {vampire.Health}, Damage: {vampire.Damage}, Ability: {vampire.Ability}, Blood Amount: {vampire.BloodAmount}");
Console.WriteLine(
    $"{werewolf.Name} - Health: {werewolf.Health}, Damage: {werewolf.Damage}, Weapon: {werewolf.Weapon}, Transformation Time: {werewolf.TransformationTime}s");
Console.WriteLine("The battle begins!");