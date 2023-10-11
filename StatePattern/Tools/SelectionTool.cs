namespace StatePattern.Tools
{
    /// <summary>
    /// The SelectionTool performs selection actions.
    /// </summary>
    public class SelectionTool : Tool
    {
        /// <summary>
        /// Performs logic when the mouse down happens. The Selection icon appears.
        /// </summary>
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        /// <summary>
        /// Performs logic when the mouse up happens. The Selection rectangle appears.
        /// </summary>
        public void MouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
