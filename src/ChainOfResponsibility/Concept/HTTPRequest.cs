namespace ChainOfResponsibility.Concept
{
    internal class HTTPRequest
    {
        private string UserName;
        private string Password;

        public HTTPRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string GetUserName()
        {
            return UserName;
        }
        public void SetUserName(string userName)
        {
            UserName = userName;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
    }
}
