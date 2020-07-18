namespace Shop
{
    /// <summary>
    /// Class of soap as a specific goods.
    /// </summary>
    public class Soap : Chemicals
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Soap() : base("Soap", 0.8)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="soap">A Soap value.</param>
        public static implicit operator int(Soap soap) => (int)(soap.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="shampoo">A Soap value.</param>
        public static implicit operator double(Soap soap) => soap.Price;
    }
}
