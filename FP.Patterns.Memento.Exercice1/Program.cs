using FP.Patterns.Memento.Exercice1;

Originator originator = new Originator();

CareTake careTake = new CareTake(originator);

originator.Name = "State 1";
careTake.Save();

originator.Name = "State 2";
careTake.Save();

careTake.Restore(0);

Console.WriteLine(originator.Name);