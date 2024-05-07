// See https://aka.ms/new-console-template for more information
using Command.Concept;
using Command.Editor;
using Command.Exercise;

var service = new CustomerSevice();
var command = new AddCustomerCommand(service);
var button = new Button(command);
button.Click();

var commands = new CompositeCommand();
commands.AddCommand(new ResizeCommand());
commands.AddCommand(new BlackAndWhiteCommand());
commands.Execute();

var history = new History();
var document = new HTMLDocument();
document.SetContent("Hello World");
var boldCommand = new BoldCommand(document, history);
boldCommand.Execute();
Console.WriteLine(document.GetContent());

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(document.GetContent());

var videoEditor = new VideoEditor();
var videohistory = new VideoCommandsHistory();
videoEditor.SetText("This is for testing");
var textCommands = new TextCommand(videohistory, videoEditor);
textCommands.Execute("This is another testing scenario");
Console.WriteLine(videoEditor.GetText());

var undoVideoCommand = new UndoVideoCommand(videohistory);
undoVideoCommand.Execute();
Console.WriteLine(videoEditor.GetText());
