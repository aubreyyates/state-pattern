namespace StatePattern.Tools
{
    /// <summary>
    /// The CircleTool performs circle actions.
    /// </summary>
    public class CircleTool : Tool
    {
        /// <summary>
        /// Performs logic when the mouse down happens. The Circle icon appears.
        /// </summary>
        public void MouseDown()
        {
            Console.WriteLine("Circle icon");
        }

        /// <summary>
        /// Performs logic when the mouse up happens. The Circle gets drawn.
        /// </summary>
        public void MouseUp()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
