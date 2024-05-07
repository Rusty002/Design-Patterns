namespace Template.Exercise
{
    public class CloseWindowActions
    {
        public void BeforeClose()
        {
            Console.WriteLine("perform action before closing");
        }
        public void AfterClose()
        {
            Console.WriteLine("perform action after closing");
        }

    }
}
