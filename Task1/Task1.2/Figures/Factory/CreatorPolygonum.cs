namespace Figures.Factory
{
    /// <summary>
    /// A factory that redefines the factory method 
    /// and returns its own figure from it.
    /// </summary>
    public class CreatorPolygonum : Creator
    {
        /// <summary>
        /// Array of coordinates.
        /// </summary>
        public Point[] Points { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="points">Array of coordinates.</param>
        public CreatorPolygonum(Point[] points)
        {
            Points = points;
        }

        /// <summary>
        /// Factory method returning your own figure.
        /// </summary>
        /// <returns>Polygonum class object.</returns>
        public override Figure CreateFigure()
        {
            return new Polygonum(Points);
        }
    }
}
