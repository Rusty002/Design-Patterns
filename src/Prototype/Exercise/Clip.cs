namespace Prototype.Exercise
{
    internal class Clip : IEditorComponent
    {
        public IEditorComponent Duplicate()
        {
            // logic for duplicating clip
            return new Clip();
        }
    }
}
