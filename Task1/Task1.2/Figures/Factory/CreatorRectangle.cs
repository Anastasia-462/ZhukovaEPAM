namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorRectangle : Creator
    {
        /// <summary>
        /// The first side of rectangle.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// The second side of rectangle.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sideA">A double number.</param>
        /// <param name="sideB">A double number.</param>
        public CreatorRectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Rectangle class object.</returns>
        public override Figure CreateFigure()
        {
            return new Rectangle(SideA, SideB);
        }
    }
}
