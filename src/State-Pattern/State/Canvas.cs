using State_Pattern.Enums;

namespace State_Pattern.State
{
    public class Canvas
    {
        private Tool CurrentTool;

        public void SetTool(Tool toolType) {  CurrentTool = toolType; }
        public Tool GetToolType()
        {
            return CurrentTool;
        }

        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }

    }
}
