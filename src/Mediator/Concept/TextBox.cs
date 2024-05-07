namespace Mediator.Concept
{
    internal class TextBox : UIControl
    {
        private string Content;

        public TextBox(DialogBox owner) : base(owner)
        {

        }
        public string GetContent()
        {
            return Content;
        }
        public void SetContent(string content)
        {
            Content = content;
            _owner.Changed(this);
        }
    }
}
