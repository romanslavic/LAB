namespace CompositePattern;

public class Permission : PermissionNode
{
    public Permission(string name) : base(name) { }

    public override void Display(int level = 0)
    {
        string spaces = new string(' ', level * 2);
        Console.WriteLine($"{spaces}- Permission: {Name}");
    }
}