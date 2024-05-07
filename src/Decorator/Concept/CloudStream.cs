namespace Decorator.Concept
{
    internal class CloudStream : IStream
    {
        public void Write(string fileBytes)
        {
            Console.WriteLine("Storing Data to Cloud " + fileBytes);
        }
    }
}
