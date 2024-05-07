namespace Strategy.Concept
{
    public interface Compressor
    {
        //byte[] Compress(byte[] fileStream);
        void Compress(string fileName);
    }
}
