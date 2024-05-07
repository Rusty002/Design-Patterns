namespace Command.Exercise
{
    internal class UndoVideoCommand : IVideoCommand
    {
        private readonly VideoCommandsHistory _command;
        public UndoVideoCommand(VideoCommandsHistory command)
        {
            _command = command;
        }
        public void Execute(object value = null)
        {
            if(_command.GetSize() > 0)
                _command.PopCommand().UnExecute();
        }
    }
}
