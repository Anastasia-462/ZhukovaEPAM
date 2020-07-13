namespace Figures
{
    /// <summary>
    /// Figure class. 
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Method to find square.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public abstract double CalcP();

        /// <summary>
        /// Method to find perimeter.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public abstract double CalcS();
    }
}
