// See https://aka.ms/new-console-template for more information
using Visitor.Concept;
using Visitor.Exercise;

Console.WriteLine("Visitor Design Pattern");

var document = new HTMLDocument();
document.AddNode(new HeadingNode());
document.AddNode(new AnchorNode());
document.Execute(new HighlightOperation());
document.Execute(new PlainTextOperation());

var soundFile = new WavFile();
soundFile.AddOperation(new FactSegment());
soundFile.AddOperation(new FormatSegment());
soundFile.Execute(new NoiseReductionOperation());
soundFile.Execute(new ReverbOperation());