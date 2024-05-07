// See https://aka.ms/new-console-template for more information
using State_Pattern.Exercise;
using State_Pattern.State;

Console.WriteLine("Hello, World!");

Canvas canvas = new Canvas();
canvas.SetTool(new BrushTool());
DirectionService directionService = new DirectionService();
directionService.SetDirectionService(new Walking());
directionService.GetDirection();
canvas.MouseDown();
canvas.MouseUp();