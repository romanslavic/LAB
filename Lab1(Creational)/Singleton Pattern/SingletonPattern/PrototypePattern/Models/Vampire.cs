namespace PrototypePattern.Models;

public class Vampire : Enemy
{
    private DateTime _spwanTime;

    public Vampire(DateTime spwanTime)
    {
        _spwanTime = spwanTime;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Level: {Level}, Hp: {Hp}, Mana: {Mana}, Item drop: {ItemDrop!.ItemName}, Spawn time: {_spwanTime}");
    }

    public override Enemy Clone()
    {
        Enemy clone = new Vampire(this._spwanTime);
        clone.Hp = Hp;
        clone.Mana = Mana;
        clone.ItemDrop = ItemDrop;
        clone.Level = Level;

        return clone;
    }
}