namespace AbstractFactory.Concept.Ant
{
    internal class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant Text Box");
        }
    }
}
