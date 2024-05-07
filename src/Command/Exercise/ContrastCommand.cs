namespace Command.Exercise
{
    internal class ContrastCommand : IVideoUndoAbleCommand
    {
        private float previousContrast;
        private readonly VideoCommandsHistory _command;
        private readonly VideoEditor _editor;
        public ContrastCommand(VideoCommandsHistory command, VideoEditor editor)
        {
            _command = command;
            _editor = editor;
        }
        public void Execute(object newValue)
        {
            previousContrast = _editor.GetContrast();
            _editor.SetContrast((float)newValue);
            _command.PushCommand(this);
        }

        public void UnExecute()
        {
            _editor.SetContrast(previousContrast);
        }
    }
}
