namespace StatePattern
{
    /// <summary>
    /// The Canvas class represents a canvas that a user can draw on. It is also known as the Context.
    /// </summary>
    public class Canvas
    {
        /// <summary>
        /// The currently selected tool.
        /// </summary>
        private Tool? CurrnetTool;

        /// <summary>
        /// Performs the logic when a mouse down happens on the canvas.
        /// </summary>
        public void MouseDown()
        {
            if (CurrnetTool == null) return;
            CurrnetTool.MouseDown();
        }

        /// <summary>
        /// Performs the logic when a mouse up happens on the canvas.
        /// </summary>
        public void MouseUp()
        {
            if (CurrnetTool == null) return;
            CurrnetTool.MouseUp();
        }

        /// <summary>
        /// Returns the currently selected tool.
        /// </summary>
        /// <returns>The currently selected tool.</returns>
        public Tool? GetCurrentTool()
        {
            return CurrnetTool;
        }

        /// <summary>
        /// Sets the currently selected tool.
        /// </summary>
        /// <param name="tool">The tool to select.</param>
        public void SetCurrentTool(Tool tool)
        {
            CurrnetTool = tool;
        }
    }
}
