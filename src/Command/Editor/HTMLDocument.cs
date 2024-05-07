namespace Command.Editor
{
    internal class HTMLDocument
    {
        private string Content;
        public void Bold()
        {
            Content = "<b>" + Content + "</b>"; 
        }
        public string GetContent()
        {
            return Content;
        }
        public void SetContent(string content)
        {
            Content = content;
        }
    }
}
