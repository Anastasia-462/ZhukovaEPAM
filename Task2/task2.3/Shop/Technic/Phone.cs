namespace Shop
{
    /// <summary>
    /// Class of phone as a specific goods.
    /// </summary>
    public class Phone : Technic
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Phone() : base("Phone", 758.9)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="phone">A Phone value.</param>
        public static implicit operator int(Phone phone) => (int)(phone.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="phone">A Phone value.</param>
        public static implicit operator double(Phone phone) => phone.Price;
    }
}
