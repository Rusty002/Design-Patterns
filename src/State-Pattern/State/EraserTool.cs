namespace State_Pattern.State
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Erase while move downwards");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase while move upwards");
        }
    }
}
