namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorEllipse : Creator
    {
        /// <summary>
        /// The first diagonal of ellipse.
        /// </summary>
        public double DialonalA { get; set; }

        /// <summary>
        /// The second diagonal of ellipse.
        /// </summary>
        public double DialonalB { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="dialonalA">A double number.</param>
        /// <param name="dialonalB">A double number.</param>
        public CreatorEllipse(double dialonalA, double dialonalB)
        {
            DialonalA = dialonalA;
            DialonalB = dialonalB;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Ellipse class object.</returns>
        public override Figure CreateFigure()
        {
            return new Ellipse(DialonalA, DialonalB);
        }
    }
}
