namespace Strategy.Concept
{
    public class JPEGCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine(fileName + " Compressed Using JPEG Compressor");
        }
    }
}
