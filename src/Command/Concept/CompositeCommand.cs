namespace Command.Concept
{
    internal class CompositeCommand : ICommand
    {
        private List<ICommand> _command = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _command.Add(command);
        }
        public void Execute()
        {
            foreach (var command in _command)
                command.Execute();
        }
    }
}
