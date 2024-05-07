// See https://aka.ms/new-console-template for more information

using Memento_Pattern.Exercise;
using Memento_Pattern.Memento;

Document document = new Document("This is test for document Class", "TimesNewRoman", 12);
Console.WriteLine(document.GetContent());
DocumentHistory documentHistory = new DocumentHistory();
documentHistory.PushState(document.CreateState());
document.SetContent("Updated Content For State");
documentHistory.PushState(document.CreateState());
document.SetContent("Updated again for testing");
document.Restore(documentHistory.PopState());
Console.WriteLine(document.GetContent());

Editor editor = new Editor();
History history = new History();

editor.SetContent("a");
history.PushState(editor.CreateState());
editor.SetContent("b");
history.PushState(editor.CreateState());
editor.SetContent("c");

editor.Restore(history.PopState());

Console.WriteLine(editor.GetContent());