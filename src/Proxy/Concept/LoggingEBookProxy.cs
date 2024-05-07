namespace Proxy.Concept
{
    internal class LoggingEBookProxy : IEbook
    {
        private readonly string FileName;
        private RealEBook EBook;
        public LoggingEBookProxy(string fileName)
        {
            FileName = fileName;
        }

        public string GetFileName()
        {
            return FileName;
        }

        public void Show()
        {
            if (EBook == null)
                EBook = new RealEBook(FileName);

            Console.WriteLine("Logging For Book: " + FileName);
            EBook.Show();
        }
    }
}
