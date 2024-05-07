namespace Decorator.Exercise
{
    internal class ErrorDecorator : IArtefact
    {
        private readonly IArtefact _editor;

        public ErrorDecorator(IArtefact editor)
        {
            _editor = editor;
        }

        public string Render()
        {
            return _editor.Render() + "[Error]";
        }
    }
}
