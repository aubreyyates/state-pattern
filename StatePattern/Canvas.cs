namespace StatePattern
{
    public class Canvas
    {
        private Tool? CurrnetTool;

        public void MouseDown()
        {
            if (CurrnetTool == null) return;
            CurrnetTool.MouseDown();
        }

        public void MouseUp()
        {
            if (CurrnetTool == null) return;
            CurrnetTool.MouseUp();
        }

        public Tool? GetCurrentTool()
        {
            return CurrnetTool;
        }

        public void SetCurrentTool(Tool tool)
        {
            CurrnetTool = tool;
        }
    }
}
