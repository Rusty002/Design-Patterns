namespace Decorator.Exercise
{
    internal class Artefact : IArtefact
    {
        private string Name;

        public Artefact(string name)
        {
            Name = name;
        }

        public string Render()
        {
            return Name;
        }
    }
}
