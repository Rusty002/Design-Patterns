namespace Command.Exercise
{
    internal interface IVideoUndoAbleCommand : IVideoCommand
    {
        void UnExecute();
    }
}
