namespace Adapter.Exercise
{
    internal class EmailClient
    {
        private List<IEmailProvider> Providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider emailProvider)
        {
            Providers.Add(emailProvider);
        }

        public void DownLoadEmails()
        {
            foreach (var provider in Providers)
                provider.DownLoadEmails();
        }
    }
}
