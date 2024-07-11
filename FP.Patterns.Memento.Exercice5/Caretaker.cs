namespace FP.Patterns.Memento.Exercice5
{
    public class Caretaker
    {
        private Originator _originator;
        private List<Memento> _history = [];

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void SaveText()
        {
            var memento = _originator.Save();
            _history.Add(memento);
        }

        public void Undo()
        {
            var memento = _history[_history.Count - 1];
            _history.Remove(memento);
            _originator.Restore(memento);
        }
    }
}
