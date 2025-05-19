using PrototypePattern.Models;

Vampire vampire1 = new Vampire(DateTime.Now)
{
    Level = 10,
    Hp = 500,
    Mana = 150,
    ItemDrop = new Item("Rusty Sword")
};

Werewolf werewolf1 = new Werewolf(DateTime.Now)
{
    Level = 14,
    Hp = 1040,
    Mana = 10,
    ItemDrop = new Item("Rusty Sword")
};

Vampire vampire2 = (Vampire)vampire1.Clone();
Werewolf werewolf2 = (Werewolf)werewolf1.Clone();

Console.WriteLine("Vampires data:");
vampire1.DisplayInfo();
vampire2.DisplayInfo();

Console.WriteLine("Werewolf data:");
werewolf1.DisplayInfo();
werewolf2.DisplayInfo();