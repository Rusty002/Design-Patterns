namespace Decorator.Concept
{
    internal class EncrytedCloudStream : IStream
    {
        private readonly IStream _cloudStream;

        public EncrytedCloudStream(IStream cloudStream)
        {
            _cloudStream = cloudStream;
        }

        public void Write(string fileByte) 
        { 
            _cloudStream.Write(Encrypt(fileByte));
        }

        public string Encrypt(string fileByte)
        {
            return "!@#%$#$^#$$#@FS#^$";
        }
    }
}
