namespace FP.Patterns.Memento.Exercice2
{
    public class History
    {
        private readonly List<TextEditorMemento> _mementoList;
        private TextEditor _textEditor;
        public History(TextEditor textEditor)
        {
            _mementoList = [];
            _textEditor = textEditor;
        }
        public void Push(TextEditorMemento memento)
        {
            _mementoList.Add(memento);
        }

        public TextEditorMemento Pop()
        {
            var memento = _mementoList[^1];
            _mementoList.Remove(memento);
            return memento;
        }

        public bool IsEmpty()
        {
            if (_mementoList.Count == 0) return false;
            return true;
        }
    }
}
