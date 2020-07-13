namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorTriangle : Creator
    {
        /// <summary>
        /// The first side of triangle.
        /// </summary>
        public double SizeA { get; set; }

        /// <summary>
        /// The second side of triangle.
        /// </summary>
        public double SizeB { get; set; }

        /// <summary>
        /// The third side of triangle.
        /// </summary>
        public double SizeC { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sizeA">A double number.</param>
        /// <param name="sizeB">A double number.</param>
        /// <param name="sizeC">A double number.</param>
        public CreatorTriangle(double sizeA, double sizeB, double sizeC)
        {
            SizeA = sizeA;
            SizeB = sizeB;
            SizeC = sizeC;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Triangle class object.</returns>
        public override Figure CreateFigure()
        {
            return new Triangle(SizeA, SizeB, SizeC);
        }
    }
}
