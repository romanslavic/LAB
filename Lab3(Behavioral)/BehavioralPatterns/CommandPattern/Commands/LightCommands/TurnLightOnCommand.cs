using System.Windows.Input;
using CommandPattern.Recievers;
using ICommand = CommandPattern.Interfaces.ICommand;

namespace CommandPattern.Commands.LightCommands;

public class TurnLightOnCommand : ICommand
{
    private readonly Light _light;

    public TurnLightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}