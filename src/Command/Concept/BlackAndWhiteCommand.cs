namespace Command.Concept
{
    internal class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Apply Black & White Filter");
        }
    }
}
