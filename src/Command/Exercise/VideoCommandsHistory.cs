namespace Command.Exercise
{
    internal class VideoCommandsHistory
    {
        private List<IVideoUndoAbleCommand> commands = new List<IVideoUndoAbleCommand>();

        public void PushCommand(IVideoUndoAbleCommand command)
        {
            commands.Add(command);
        }
        public IVideoUndoAbleCommand PopCommand()
        {
            return commands[commands.Count - 1];
        }

        public int GetSize()
        {
            return commands.Count;
        }
    }
}
