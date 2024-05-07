namespace ChainOfResponsibility.Concept
{
    internal abstract class Handler
    {
        private Handler Next;

        public Handler(Handler next)
        {
            Next = next;
        }
        public void Handle(HTTPRequest request)
        {
            if(DoHandle(request))
                return;

            if(Next != null)
                Next.Handle(request);
        }
        public abstract bool DoHandle(HTTPRequest request);
    }
}
