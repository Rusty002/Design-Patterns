namespace Mediator.Concept
{
    internal class ArticlesDialogBox : DialogBox
    {
        private ListBox _articlesListBox;
        private TextBox _titleTextBox;
        private Button _button;
        public void SimulateUserInteraction()
        {
            _articlesListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _button = new Button(this);
            _articlesListBox.SetSelection("Article 1");
            _titleTextBox.SetContent("");
            _titleTextBox.SetContent("Article 2");
            Console.WriteLine("Text Box " + _titleTextBox.GetContent());
            Console.WriteLine("Button " + _button.GetIsEnabled());
        }
        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
                ArticleSelected();
            else if (control == _titleTextBox)
                TitleChanged();
        }
        private void TitleChanged()
        {
            var content = _titleTextBox.GetContent();
            var isEmpty = String.IsNullOrEmpty(content);
            _button.SetIsEnabled(!isEmpty);
        }
        private void ArticleSelected()
        {
            _titleTextBox.SetContent(_articlesListBox.GetSelection());
            _button.SetIsEnabled(true);
        }
    }
}
