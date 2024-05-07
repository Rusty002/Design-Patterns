namespace ChainOfResponsibility.Exercise
{
    internal class MemoryBlock
    {
        private DataReaderHandler _reader;

        public MemoryBlock(DataReaderHandler reader)
        {
            _reader = reader;
        }

        public void Handle(DataReader reader)
        {
            _reader.Handle(reader);
        }
    }
}
