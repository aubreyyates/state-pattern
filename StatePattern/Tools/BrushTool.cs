namespace StatePattern.Tools
{
    /// <summary>
    /// The BrushTool performs brush actions.
    /// </summary>
    public class BrushTool : Tool
    {
        /// <summary>
        /// Performs logic when the mouse down happens. The Brush icon appears.
        /// </summary>
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        /// <summary>
        /// Performs logic when the mouse up happens. The Brush line gets drawn.
        /// </summary>
        public void MouseUp()
        {
            Console.WriteLine("Draw brushed line");
        }
    }
}
