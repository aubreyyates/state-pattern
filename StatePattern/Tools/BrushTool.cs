namespace StatePattern.Tools
{
    public class BrushTool : Tool
    {
        void Tool.MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        void Tool.MouseUp()
        {
            Console.WriteLine("Draw brushed line");
        }
    }
}
