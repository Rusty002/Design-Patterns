namespace AbstractFactory.Concept.Ant
{
    internal class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}
