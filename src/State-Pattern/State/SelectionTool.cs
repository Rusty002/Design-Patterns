namespace State_Pattern.State
{
    public class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw something");
        }
    }
}
