using CommandPattern.Interfaces;
using CommandPattern.Recievers;

namespace CommandPattern.Commands.DoorCommands;

public class LockDoorCommand : ICommand
{
    private readonly Door _door;

    public LockDoorCommand(Door door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Lock();
    }
}