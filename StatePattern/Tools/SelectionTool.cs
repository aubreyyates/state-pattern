namespace StatePattern.Tools
{
    public class SelectionTool : Tool
    {
        void Tool.MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        void Tool.MouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
