namespace Proxy.Concept
{
    internal class Library
    {
        private Dictionary<string, dynamic> Ebooks = new Dictionary<string, dynamic>();

        public void Add(dynamic book)
        {
            if (!Ebooks.ContainsKey(book.GetFileName()))
                Ebooks.Add(book.GetFileName(), book);
        }

        public void OpenEbook(string fileName)
        {
            if(Ebooks.ContainsKey(fileName))
                Ebooks[fileName].Show();
        }
    }
}
