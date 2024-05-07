namespace State_Pattern.State
{
    public class BrushTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Draw using brush downwards");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw using brush upwards");
        }
    }
}
