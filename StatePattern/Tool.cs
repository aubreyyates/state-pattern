namespace StatePattern
{
    /// <summary>
    /// The Tool interface provides needed methods for a class to be a usable tool on the canvas.
    /// </summary>
    public interface Tool
    {
        /// <summary>
        /// Performs the logic when a mouse down happens on the canvas.
        /// </summary>
        public void MouseDown();

        /// <summary>
        /// Performs the logic when a mouse up happens on the canvas.
        /// </summary>
        public void MouseUp();
    }
}
