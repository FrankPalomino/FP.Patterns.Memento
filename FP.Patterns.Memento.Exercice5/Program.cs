using FP.Patterns.Memento.Exercice5;

Originator editor = new();
Caretaker caretaker = new Caretaker(editor);

editor.Text = "Este es el primer texto";
caretaker.SaveText();

Console.WriteLine(editor.Text);

editor.Text = "Este es el segundo texto";
caretaker.SaveText();

Console.WriteLine(editor.Text);

editor.Text = "Este es el tercer texto";
Console.WriteLine(editor.Text);

caretaker.Undo();

Console.WriteLine(editor.Text);

caretaker.Undo();

Console.WriteLine(editor.Text);
