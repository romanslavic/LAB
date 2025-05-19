using CommandPattern.Commands.DoorCommands;
using CommandPattern.Commands.LightCommands;
using CommandPattern.Commands.ThermostatCommands;
using CommandPattern.Invokers;
using CommandPattern.Recievers;

var light = new Light();
var thermostat = new Thermostat();
var door = new Door();

var turnOffLight = new TurnLightOffCommand(light);
var lockDoor = new LockDoorCommand(door);
var setTemp = new SetTemperatureCommand(thermostat, 24.5);

var remote = new SmartHomeRemote();

remote.SetCommand(turnOffLight);
remote.ExecuteCommand();

remote.SetCommand(lockDoor);
remote.ExecuteCommand();

remote.SetCommand(setTemp);
remote.ExecuteCommand();