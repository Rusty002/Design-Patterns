namespace AbstractFactory.Concept.Material
{
    internal class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material Text Box");
        }
    }
}
