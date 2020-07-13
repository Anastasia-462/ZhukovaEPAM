namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorTrapeze : Creator
    {
        /// <summary>
        /// The first side of trapeze.
        /// </summary>
        public double SizeA { get; set; }

        /// <summary>
        /// The second side of trapeze.
        /// </summary>
        public double SizeB { get; set; }

        /// <summary>
        /// The third side of trapeze.
        /// </summary>
        public double SizeC { get; set; }

        /// <summary>
        /// The forth side of trapeze.
        /// </summary>
        public double SizeD { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sizeA">A double number.</param>
        /// <param name="sizeB">A double number.</param>
        /// <param name="sizeC">A double number.</param>
        /// <param name="sizeD">A double number.</param>
        public CreatorTrapeze(double sizeA, double sizeB, double sizeC, double sizeD)
        {
            SizeA = sizeA;
            SizeB = sizeB;
            SizeC = sizeC;
            SizeD = sizeD;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Trapeze class object.</returns>
        public override Figure CreateFigure()
        {
            return new Trapeze(SizeA, SizeB, SizeC, SizeD);
        }
    }
}
