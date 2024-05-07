namespace Decorator.Exercise
{
    internal class MainDecorator : IArtefact
    {
        private readonly IArtefact _editor;

        public MainDecorator(IArtefact editor)
        {
            _editor = editor;
        }

        public string Render()
        {
            return _editor.Render() + " [Main]";
        }
    }
}
