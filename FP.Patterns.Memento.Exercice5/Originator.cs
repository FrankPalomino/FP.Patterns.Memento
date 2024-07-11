namespace FP.Patterns.Memento.Exercice5
{
    public class Originator
    {
        public string Text { get; set; }

        public Memento Save()
        {
            return new Memento(Text);
        }

        public void Restore(Memento memento)
        {
            Text = memento._text;
        }
    }

    public class Memento
    {
        internal readonly string _text;

        public Memento(string text)
        {
            _text = text;
        }
    }
}
