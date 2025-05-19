using CommandPattern.Interfaces;

namespace CommandPattern.Invokers;

public class SmartHomeRemote
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}