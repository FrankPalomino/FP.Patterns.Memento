namespace FP.Patterns.Memento.Exercice1
{
    public class Originator
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; Save(); }
        }

        public Memento Save()
        {
            Memento m = new Memento(_name);
            return m;
        }

        public void Restore(Memento m)
        {
            _name = m.GetState();
        }
    }
}
