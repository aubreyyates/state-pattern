namespace StatePattern.Tools
{
    /// <summary>
    /// The CircleTool performs circle actions.
    /// </summary>
    public class CircleTool : Tool
    {
        /// <summary>
        /// Performs logic when the mouse down happens. The circle icon appears.
        /// </summary>
        void Tool.MouseDown()
        {
            Console.WriteLine("Circle icon");
        }

        /// <summary>
        /// Performs logic when the mouse up happens. The circle gets drawn.
        /// </summary>
        void Tool.MouseUp()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
