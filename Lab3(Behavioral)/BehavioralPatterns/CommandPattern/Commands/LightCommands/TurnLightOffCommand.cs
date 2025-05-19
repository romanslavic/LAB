using CommandPattern.Interfaces;
using CommandPattern.Recievers;

namespace CommandPattern.Commands.LightCommands;

public class TurnLightOffCommand : ICommand
{
    private readonly Light _light;

    public TurnLightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}