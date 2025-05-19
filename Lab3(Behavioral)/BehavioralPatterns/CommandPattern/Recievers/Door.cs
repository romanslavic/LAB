namespace CommandPattern.Recievers;

public class Door
{
    public void Lock() => Console.WriteLine("Door is locked");
    public void Unlock() => Console.WriteLine("Door is unlocked");
}