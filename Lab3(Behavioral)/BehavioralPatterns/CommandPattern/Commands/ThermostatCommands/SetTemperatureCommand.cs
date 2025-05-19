using CommandPattern.Interfaces;
using CommandPattern.Recievers;

namespace CommandPattern.Commands.ThermostatCommands;

public class SetTemperatureCommand : ICommand
{
    private readonly Thermostat _thermostat;
    private readonly double _temperature;

    public SetTemperatureCommand(Thermostat thermostat, double temperature)
    {
        _thermostat = thermostat;
        _temperature = temperature;
    }

    public void Execute()
    {
        _thermostat.SetTemperature(_temperature);
    }
}