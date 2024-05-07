namespace Iterator.Iterator
{
    public class BrowserHistory
    {
        private string[] Urls = new string[10];
        private int index = 0;

        public string[] GetUrls() 
        { 
            return Urls;
        }
        public void PushUrl(string url)
        {
            Urls[index] = url;
            index++;
        }

        public string PopUrl() 
        {
            var lastUrl = Urls[Urls.Length - 1];
            var lastUrlIndex = Urls.Length - 1;
            Urls[lastUrlIndex] = "";
            return lastUrl;
        }

        public ITerator CreateIterator()
        {
            return new ArrayIterator(this);
        }

        public class ArrayIterator : ITerator
        {
            private BrowserHistory history;
            private int index;

            public ArrayIterator(BrowserHistory _history)
            {
                history = _history;
            }
            public object Current()
            {
                return history.GetUrls()[index];
            }

            public bool HasNext()
            {
                return index < history.GetUrls().Length;
            }

            public void Next()
            {
                index++;
            }
        }

        //public class ListIterator : ITerator
        //{
        //    private BrowserHistory history;
        //    private int index;

        //    public ListIterator(BrowserHistory _history)
        //    {
        //        history = _history;
        //    }
        //    public object Current()
        //    {
        //        return history.GetUrls()[index];
        //    }

        //    public bool HasNext()
        //    {
        //        return index < history.GetUrls().Length;
        //    }

        //    public void Next()
        //    {
        //        index++;
        //    }
        //}
    }
}
