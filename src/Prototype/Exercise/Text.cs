namespace Prototype.Exercise
{
    internal class Text : IEditorComponent
    {
        private readonly string Content;

        public Text(string content)
        {
            Content = content;
        }

        public IEditorComponent Duplicate()
        {
            return new Text(Content);
        }

        public string GetContent()
        {
            return Content;
        }
    }
}
