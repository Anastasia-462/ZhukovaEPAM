namespace Shop
{
    /// <summary>
    /// Class of toothpaste as a specific goods.
    /// </summary>
    public class Toothpaste : Chemicals
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Toothpaste() : base("Toothpaste", 5.5)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="toothpaste">A Toothpaste value.</param>
        public static implicit operator int(Toothpaste toothpaste) => (int)(toothpaste.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="toothpaste">A Toothpaste value.</param>
        public static implicit operator double(Toothpaste toothpaste) => toothpaste.Price;
    }
}
