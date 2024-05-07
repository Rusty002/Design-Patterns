namespace Builder.Concept
{
    internal class Presentation
    {
        private List<Slide> Slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            Slides.Add(slide);
        }

        public void Export(IPresentationBuilder presentationBuilder)
        {
            presentationBuilder.AddSlide(new Slide("Copyright"));
            foreach (var slide in Slides)
                presentationBuilder.AddSlide(slide);
        }
    }
}
