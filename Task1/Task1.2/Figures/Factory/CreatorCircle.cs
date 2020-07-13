namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorCircle : Creator
    {
        /// <summary>
        /// Radius of circle.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="radius">A double number.</param>
        public CreatorCircle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Circle class object.</returns>
        public override Figure CreateFigure()
        {
            return new Circle(Radius);
        }
    }
}
