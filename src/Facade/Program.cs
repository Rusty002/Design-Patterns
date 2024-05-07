// See https://aka.ms/new-console-template for more information
using Facade.Concept;
using Facade.Exercise;

Console.WriteLine("Facade Design Pattern!");

var notifcation = new NotificationService();
notifcation.Send("This is for testing", "123-123-123");

var demo = new Demo();
demo.Show();