namespace PrototypePattern.Models;

public class Werewolf : Enemy
{
    private DateTime _spawnTime;

    public Werewolf(DateTime spawnTime)
    {
        _spawnTime = spawnTime;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Level: {Level}, Hp: {Hp}, Mana: {Mana}, Item drop: {ItemDrop!.ItemName}, Spawn time: {_spawnTime}");
    }

    public override Enemy Clone()
    {
        Werewolf clone = new Werewolf(this._spawnTime);
        clone.Hp = Hp;
        clone.Mana = Mana;
        clone.ItemDrop = ItemDrop;
        clone.Level = Level;
        return clone;
    }
}