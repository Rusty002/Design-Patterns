// See https://aka.ms/new-console-template for more information
using FlyWeight.Concept;
using FlyWeight.Exercise;
Console.WriteLine("FlyWeight Pattern!");

var services = new PointService(new PointIconFactory());
foreach (var service in services.GetPoints())
    service.Draw();

Demo.Show();
