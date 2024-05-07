// See https://aka.ms/new-console-template for more information
using Template.Concept;
using Template.Exercise;

Console.WriteLine("Hello, World!");
TransferMoneyTask transferMoneyTask = new TransferMoneyTask();
transferMoneyTask.Execute();

Window window = new Window();
window.Close();