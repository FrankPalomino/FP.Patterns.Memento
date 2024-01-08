using FP.Patterns.Memento.Exercice2;

TextEditor editor = new TextEditor();
History history = new History(editor);

editor.SetText("Hola Mundo");
history.Push(editor.CreateMemento());

editor.SetText("Second text");
history.Push(editor.CreateMemento());

editor.SetText("Final text");

Console.WriteLine(editor.GetText());

editor.RestoreFromMemento(history.Pop());
Console.WriteLine(editor.GetText());
editor.RestoreFromMemento(history.Pop());
Console.WriteLine(editor.GetText());
