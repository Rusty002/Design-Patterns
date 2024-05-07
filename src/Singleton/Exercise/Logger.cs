namespace Singleton.Exercise
{
    internal class Logger
    {
        private string FileName;
        private static Dictionary<string, Logger> Instances = new Dictionary<string, Logger>();
        private Logger(string fileName)
        {
            FileName = fileName;
        }

        public static Logger GetInstance(string fileName)
        {
            if(!Instances.ContainsKey(fileName))
                Instances.Add(fileName, new Logger(fileName));
            return Instances[fileName];
        }

        public void Write(string message)
        {
            Console.WriteLine("Writing a message to the log." + message);
        }
    }
}
