namespace Command.Editor
{
    internal interface IUndoAbleCommand : ICommand
    {
        void UnExecute();
    }
}
