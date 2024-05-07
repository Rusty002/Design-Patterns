namespace Command.Editor
{
    internal class UndoCommand : ICommand
    {
        private History _history;
        public UndoCommand(History history)
        {
            _history = history;
        }
        public void Execute()
        {
            if(_history.Size() > 0)
                _history.PopCommand().UnExecute();
        }
    }
}
