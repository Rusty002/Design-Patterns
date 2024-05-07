namespace Memento_Pattern.Memento
{
    public class EditorState
    {
        private readonly string content;
        public string GetContent()
        {
            return content;
        }
        public EditorState(string currentContent)
        {
            content = currentContent;
        }
    }
}
