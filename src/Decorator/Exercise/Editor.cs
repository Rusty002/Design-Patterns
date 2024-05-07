namespace Decorator.Exercise
{
    internal class Editor
    {
        public void OpenProject(String path)
        {
            List<Artefact> artefacts = new List<Artefact>{
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            //artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
            //artefacts[2] = new ErrorDecorator(artefacts[2]);

            foreach (var artefact in artefacts)
                Console.WriteLine(artefact.Render());
        }
    }
}
