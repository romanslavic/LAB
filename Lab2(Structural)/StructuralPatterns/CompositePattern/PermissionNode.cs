namespace CompositePattern;

public abstract class PermissionNode
{
    public string Name { get; }

    protected PermissionNode(string name)
    {
        Name = name;
    }
    
    public abstract void Display(int level);
}