namespace Prototype.Exercise
{
    internal class TimeLine
    {
        private List<IEditorComponent> Components = new List<IEditorComponent>();

        public void Add(IEditorComponent component)
        {
            Components.Add(component);
        }
    }
}
