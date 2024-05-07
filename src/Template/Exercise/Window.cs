namespace Template.Exercise
{
    public class Window : Action
    {

        protected override void OnClose()
        {
            Console.WriteLine("Close window generally");
        }
    }
}
