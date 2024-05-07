namespace Memento_Pattern.Memento
{
    public class Editor
    {
        private string Content;

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string value)
        {
            Content = value;
        }

        public void Restore(EditorState editorState)
        {
            Content = editorState.GetContent();
        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }
    }
}
