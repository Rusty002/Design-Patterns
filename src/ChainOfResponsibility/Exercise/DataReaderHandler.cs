namespace ChainOfResponsibility.Exercise
{
    internal abstract class DataReaderHandler
    {
        private DataReaderHandler Next;

        public DataReaderHandler(DataReaderHandler next)
        {
            Next = next;
        }

        public void Handle(DataReader reader)
        {
            if (DoHandle(reader))
                return;

            if(Next != null)
                Next.Handle(reader);
        }
        public abstract bool DoHandle(DataReader next);
    }
}
