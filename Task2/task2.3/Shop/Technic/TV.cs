namespace Shop
{
    /// <summary>
    /// Class of TV as a specific goods.
    /// </summary>
    public class TV : Technic
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public TV() : base("Television", 2054.25)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="tv">A TV value.</param>
        public static implicit operator int(TV tv) => (int)(tv.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="tv">A TV value.</param>
        public static implicit operator double(TV tv) => tv.Price;
    }
}
