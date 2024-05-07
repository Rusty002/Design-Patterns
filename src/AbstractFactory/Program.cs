// See https://aka.ms/new-console-template for more information
using AbstractFactory.Concept.Ant;
using AbstractFactory.Concept.App;
using AbstractFactory.Concept.Material;
using AbstractFactory.Exercise;

Console.WriteLine("Abstract Factory Design Pattern!");

new ContactForm().Render(new AntWidgetFactory());
new ContactForm().Render(new MaterialWidgetFactory());

Demo.Show();