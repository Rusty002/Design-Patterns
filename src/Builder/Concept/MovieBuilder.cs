namespace Builder.Concept
{
    internal class MovieBuilder : IPresentationBuilder
    {
        private Movie movie = new Movie();
        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.GetText(), 0);
        }

        public Movie GetMovie() 
        { 
            return movie;
        }
    }
}
