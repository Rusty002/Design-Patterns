namespace Facade.Exercise
{
    internal class Demo
    {
        public void Show()
        {
            var tweets = new TweetService("appkey", "secret");
            tweets.GetTweets();
        }
    }
}
