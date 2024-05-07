namespace ChainOfResponsibility.Exercise
{
    internal class DataReader
    {
        private string FileName;

        public DataReader(string fileName)
        {
            FileName = fileName;
        }
        public string GetFileName() 
        { 
            return FileName;
        }
        public void SetFileName(string fileName)
        {
            FileName = fileName;
        }
    }
}
