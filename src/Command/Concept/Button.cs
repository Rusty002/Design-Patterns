namespace Command.Concept
{
    internal class Button
    {
        private string Label;
        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
        public string GetLabel() { return Label; }
        public void SetLabel(string label)
        {
            Label = label;
        }
    }
}
