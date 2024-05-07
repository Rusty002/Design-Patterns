namespace Command.Exercise
{
    internal class TextCommand : IVideoUndoAbleCommand
    {
        private string previousText;
        private readonly VideoCommandsHistory _command;
        private readonly VideoEditor _editor;
        public TextCommand(VideoCommandsHistory command, VideoEditor editor)
        {
            _command = command;
            _editor = editor;
        }
        public void Execute(object newValue)
        {
            previousText = _editor.GetText();
            _editor.SetText((string)newValue);
            _command.PushCommand(this);
        }

        public void UnExecute()
        {
            _editor.SetText(previousText);
        }
    }
}
