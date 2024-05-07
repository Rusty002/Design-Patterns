// See https://aka.ms/new-console-template for more information
using Singleton.Concept;
using Singleton.Exercise;

Console.WriteLine("Singleton Design Pattern!");

var setting = ConfigManager.GetInstance();

setting.Set("dbconnectionString", "connectionString");

var otherSetting = ConfigManager.GetInstance();

Console.WriteLine(otherSetting.Get("dbconnectionString"));

Demo.Show();