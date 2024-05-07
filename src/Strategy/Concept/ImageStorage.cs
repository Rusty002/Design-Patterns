namespace Strategy.Concept
{
    public class ImageStorage
    {
        //private Compressor Compressor;
        //private Filter Filter;

        //public ImageStorage(Compressor compressor, Filter filter)
        //{
        //    Compressor = compressor;
        //    Filter = filter;
        //} 

        public void Store(string fileName, Compressor compressor, Filter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }

    }
}
