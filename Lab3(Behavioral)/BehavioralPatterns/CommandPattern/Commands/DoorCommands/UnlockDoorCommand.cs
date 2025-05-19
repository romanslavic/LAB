using CommandPattern.Interfaces;
using CommandPattern.Recievers;

namespace CommandPattern.Commands.DoorCommands;

public class UnlockDoorCommand : ICommand
{
    private readonly Door _door;

    public UnlockDoorCommand(Door door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Unlock();
    }
}