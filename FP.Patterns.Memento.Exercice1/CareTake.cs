namespace FP.Patterns.Memento.Exercice1
{
    public class CareTake
    {
        private List<Memento> _mementos = new List<Memento>();
        private Originator _originator;

        public CareTake(Originator originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            _mementos.Add(_originator.Save());
        }

        public void Restore(int index)
        {
            _originator.Restore(_mementos[index]);
        }
    }
}
