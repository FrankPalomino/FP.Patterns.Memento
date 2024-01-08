namespace FP.Patterns.Memento.Exercice2
{
    public class TextEditor
    {
        private string _text;

        public TextEditor()
        {
            _text = string.Empty;
        }
        public void SetText(string content)
        {
            _text = content;
        }

        public string GetText()
        {
            return _text;
        }

        public TextEditorMemento CreateMemento()
        {
            TextEditorMemento memento = new TextEditorMemento(_text);
            return memento;
        }

        public void RestoreFromMemento(TextEditorMemento memento)
        {
            _text = memento.GetState();
        }
    }
}
