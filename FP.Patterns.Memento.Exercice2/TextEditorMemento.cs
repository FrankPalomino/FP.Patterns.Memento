namespace FP.Patterns.Memento.Exercice2
{
    public class TextEditorMemento
    {
        private string _text;

        public TextEditorMemento(string text)
        {
            _text = text;
        }

        public string GetState()
        {
            return _text;
        }
    }
}
