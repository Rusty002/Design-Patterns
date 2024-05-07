namespace Prototype.Exercise
{
    internal class Audio : IEditorComponent
    {
        public IEditorComponent Duplicate()
        {
            // logic for duplicating audio
            return new Audio();
        }
    }
}
