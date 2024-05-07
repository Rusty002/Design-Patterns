// See https://aka.ms/new-console-template for more information
using Builder.Concept;

Console.WriteLine("Builder Design Pattern!");

var presentation = new Presentation();
presentation.AddSlide(new Slide("Slide 1"));
presentation.AddSlide(new Slide("Slide 2"));

var builder = new MovieBuilder();

presentation.Export(builder);

builder.GetMovie ();