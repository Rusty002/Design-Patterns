namespace ChainOfResponsibility.Concept
{
    internal class WebServer
    {
        private Handler Handler;

        public WebServer(Handler handler)
        {
            Handler = handler;
        }

        public void Handle(HTTPRequest request)
        {
            Handler.Handle(request);
        }
    }
}
