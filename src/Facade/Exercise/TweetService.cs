namespace Facade.Exercise
{
    internal class TweetService
    {
        private string AppKey;
        private string Secret;

        public TweetService(string appkey, string secret)
        {
            AppKey = appkey;
            Secret = secret;
        }

        public List<Tweet> GetTweets()
        {
            var twitterClient = new TwitterClient();
            return twitterClient.GetRecentTweets(GetAccessToken());
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken(AppKey, Secret);
            return oauth.getAccessToken(requestToken);
        }
    }
}
