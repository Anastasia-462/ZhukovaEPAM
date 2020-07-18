namespace Shop
{
    /// <summary>
    /// Class of milk as a specific goods.
    /// </summary>
    public class Milk : FoodSupply
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Milk() : base("Milk", 1.65)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="milk">A Milk value.</param>
        public static implicit operator int(Milk milk) => (int)(milk.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="milk">A Milk value.</param>
        public static implicit operator double(Milk milk) => milk.Price;
    }
}
