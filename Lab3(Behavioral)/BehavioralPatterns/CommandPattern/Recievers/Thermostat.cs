namespace CommandPattern.Recievers;

public class Thermostat
{
    public void SetTemperature(double temperature) => 
        Console.WriteLine("Setting temperature to " + temperature);
}