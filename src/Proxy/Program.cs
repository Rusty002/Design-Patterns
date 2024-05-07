// See https://aka.ms/new-console-template for more information
using Proxy.Concept;
using Proxy.Exercise;

Console.WriteLine("Proxy Design Pattern!");

var library = new Library();
List<string> ebooks = new List<string>() { "a", "b", "c"};
foreach (var ebook in ebooks)
    library.Add(new LoggingEBookProxy(ebook));

library.OpenEbook("a");

Demo.Show();