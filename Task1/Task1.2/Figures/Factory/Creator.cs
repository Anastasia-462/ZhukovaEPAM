namespace Figures.Factory
{
    /// <summary>
    /// The base class of the factory.
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// Factory method that creates the figure class.
        /// </summary>
        /// <returns>Class object Figure.</returns>
        public abstract Figure CreateFigure();
    }
}
