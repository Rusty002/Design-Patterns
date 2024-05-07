namespace Strategy.Concept
{
    public class PNGCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine(fileName + " Compressed Using PNG Compressor Method.");
        }
    }
}
