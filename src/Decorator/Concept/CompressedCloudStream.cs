namespace Decorator.Concept
{
    internal class CompressedCloudStream : IStream
    {
        private readonly IStream _stream;

        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string fileBytes)
        {
            _stream.Write(CompressedData(fileBytes));
        }

        private string CompressedData(string fileBytes)
        {
            return ">>>...<<<";
        } 
    }
}
