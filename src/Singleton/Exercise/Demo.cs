namespace Singleton.Exercise
{
    internal class Demo
    {
        public static void Show()
        {
            var logger1 = Logger.GetInstance("file1");
            var logger2 = Logger.GetInstance("file1");
            Console.WriteLine(logger1 == logger2);

            var logger3 = Logger.GetInstance("file2");
            Console.WriteLine(logger1 == logger3);
        }
    }
}
