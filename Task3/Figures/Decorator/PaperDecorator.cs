namespace Figures
{
    /// <summary>
    /// A specific figure decorator.
    /// </summary>
    public class PaperDecorator : Decorator, IPaper
    {
        private Colors color;

        // The color of the figure.
        Colors IPaper.Color { get => color; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">The figure to be decorated.</param>
        /// <param name="color">Color of the figure.</param>
        public PaperDecorator(Figure figure, Colors color = Colors.None) : base(figure)
        {
            this.color = color;
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is PaperDecorator decorator &&
                   base.Equals(obj) &&
                   color == decorator.color;
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1570605816;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + color.GetHashCode();
            return hashCode;
        }
    }
}
