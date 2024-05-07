namespace Prototype.Exercise
{
    internal class Context
    {
        private readonly TimeLine Timeline;

        public Context(TimeLine timeline)
        {
            Timeline = timeline;
        }

        public void Duplicate(IEditorComponent component)
        {
            component.Duplicate();
        }
    }
}
