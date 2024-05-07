// See https://aka.ms/new-console-template for more information
using Bridge.Concept;

Console.WriteLine("Bridge Design Pattern!");

var remoteControl = new AdvancedRemoteControl(new SamsungTV());
remoteControl.TurnOn();
remoteControl.TurnOff();
