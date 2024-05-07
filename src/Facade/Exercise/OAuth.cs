namespace Facade.Exercise
{
    internal class OAuth
    {
        public string requestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string getAccessToken(string requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
