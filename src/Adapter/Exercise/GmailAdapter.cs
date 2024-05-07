using Adapter.Exercise.Gmail;

namespace Adapter.Exercise
{
    internal class GmailAdapter : IEmailProvider
    {
        private GmailClient _client;

        public GmailAdapter(GmailClient client)
        {
            _client = client;
        }

        public void DownLoadEmails()
        {
            _client.GetEmails();
        }
    }
}
