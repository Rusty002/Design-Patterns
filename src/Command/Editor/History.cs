namespace Command.Editor
{
    internal class History
    {
        private List<IUndoAbleCommand> commands = new List<IUndoAbleCommand>();
        public void PushCommand(IUndoAbleCommand command)
        {
            commands.Add(command);
        }
        public IUndoAbleCommand PopCommand()
        {
            return commands[commands.Count - 1];
        }
        public int Size() 
        { 
            return commands.Count;
        }
    }
}
