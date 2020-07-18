namespace Shop
{
    /// <summary>
    /// Class of milk as a specific goods.
    /// </summary>
    public class Bread : FoodSupply
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Bread() : base("Bread", 0.69)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="bread">A Bread value.</param>
        public static implicit operator int(Bread bread) => (int)(bread.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="bread">A Bread value.</param>
        public static implicit operator double(Bread bread) => bread.Price;
    }
}
