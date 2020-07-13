namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorRhombus : Creator
    {
        /// <summary>
        /// The first diagonal of rhombus.
        /// </summary>
        public double DiagonalA { get; set; }

        /// <summary>
        /// The second diagonal of rhombus.
        /// </summary>
        public double DiagonalB { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="diagonalA">A double number.</param>
        /// <param name="diagonalB">A double number.</param>
        public CreatorRhombus(double diagonalA, double diagonalB)
        {
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Rhombus class object.</returns>
        public override Figure CreateFigure()
        {
            return new Rhombus(DiagonalA, DiagonalB);
        }
    }
}
