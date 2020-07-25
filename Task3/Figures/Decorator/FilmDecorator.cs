namespace Figures
{
    /// <summary>
    /// A specific figure decorator.
    /// </summary>
    public class FilmDecorator : Decorator, IFilm
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">The figure to be decorated.</param>
        public FilmDecorator(Figure figure) : base(figure)
        {
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is FilmDecorator && base.Equals(obj);
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the decorator.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
