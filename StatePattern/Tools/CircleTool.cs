namespace StatePattern.Tools
{
    public class CircleTool : Tool
    {
        void Tool.MouseDown()
        {
            Console.WriteLine("Circle icon");
        }

        void Tool.MouseUp()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
