using FP.Patterns.Memento;

Originator auto = new Originator("BMW", 5, 100000);
auto.Show();

CareTaker careTaker = new CareTaker();

careTaker.Memento = auto.CreateMemento();

auto.Name = "Mercedes";
auto.Model = 7;
auto.Price = 200000;
auto.Show();

auto.Restore(careTaker.Memento);
auto.Show();