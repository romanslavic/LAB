namespace PrototypePattern.Models;

public abstract class Enemy
{
    public int Level;
    public int Hp;
    public int Mana;
    public Item? ItemDrop;

    public abstract void DisplayInfo();

    public abstract Enemy Clone();
}