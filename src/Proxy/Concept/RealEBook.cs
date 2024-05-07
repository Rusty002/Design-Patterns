namespace Proxy.Concept
{
    internal class RealEBook : IEbook
    {
        private readonly string FileName;

        public RealEBook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        public void Load()
        {
            Console.WriteLine("loading the Ebook: " + FileName); 
        }
        public void Show()
        {
            Console.WriteLine("Showing the Ebook: " + FileName);
        }
        public string GetFileName()
        {
            return FileName;
        }
    }
}
