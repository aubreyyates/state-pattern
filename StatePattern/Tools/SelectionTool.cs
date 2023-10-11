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
        void Tool.MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        /// <summary>
        /// Performs logic when the mouse up happens. The selection rectangle appears.
        /// </summary>
        void Tool.MouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
