namespace Command.Editor
{
    internal class BoldCommand : IUndoAbleCommand
    {
        private string PreviousContent;
        private readonly HTMLDocument _document;
        private readonly History _history;

        public BoldCommand(HTMLDocument document, History history)
        {
            _document = document;
            _history = history;
        }
        public void Execute()
        {
            PreviousContent = _document.GetContent();
            _document.Bold();
            _history.PushCommand(this);
        }

        public void UnExecute()
        {
            _document.SetContent(PreviousContent);
        }
    }
}
