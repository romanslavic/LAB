namespace CompositePattern;

public class Role : PermissionNode
{
    private readonly List<PermissionNode> _children = [];

    public Role(string name) : base(name) { }

    public void Add(PermissionNode node)
    {
        _children.Add(node);
    }

    public void Remove(PermissionNode node)
    {
        _children.Remove(node);
    }

    public override void Display(int level = 0)
    {
        string spaces = new string(' ', level * 2);
        Console.WriteLine($"{spaces}+ Role: {Name}");

        foreach (var child in _children)
        {
            child.Display(level + 1);
        }
    }
}