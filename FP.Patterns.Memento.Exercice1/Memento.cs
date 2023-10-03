namespace FP.Patterns.Memento.Exercice1
{
    public class Memento
    {
        private readonly string _name;

        public Memento(string name)
        {
            _name = name;
        }

        public string GetState()
        {
            return _name;
        }
    }
}
