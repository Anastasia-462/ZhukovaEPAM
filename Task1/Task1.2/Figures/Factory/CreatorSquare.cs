namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorSquare : Creator
    {
        /// <summary>
        /// The side of square.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sideA">A double number.</param>
        public CreatorSquare(double sideA)
        {
            SideA = sideA;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Square class object.</returns>
        public override Figure CreateFigure()
        {
            return new Square(SideA);
        }
    }
}
