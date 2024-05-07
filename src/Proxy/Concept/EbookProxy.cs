namespace Proxy.Concept
{
    internal class EbookProxy : IEbook
    {
        private readonly string FileName;
        private RealEBook EBook;

        public EbookProxy(string fileName)
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

            EBook.Show();
        }
    }
}
