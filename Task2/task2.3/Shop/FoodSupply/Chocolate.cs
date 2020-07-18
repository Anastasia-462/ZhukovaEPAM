namespace Shop
{
    /// <summary>
    /// Class of chocolate as a specific goods.
    /// </summary>
    public class Chocolate : FoodSupply
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Chocolate() : base("Chocolate", 2.26)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="chocolate">A Chocolate value.</param>
        public static implicit operator int(Chocolate chocolate) => (int)(chocolate.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="chocolate">A Chocolate value.</param>
        public static implicit operator double(Chocolate chocolate) => chocolate.Price;
    }
}
